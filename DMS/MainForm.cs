using DMS.DTO;
using DMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DMS
{
	public partial class MainForm : Form
	{
		#region Fields

		protected internal UserDTO loggedUser = null;
		private FormsControlService _formsService;
		private FilesBusinessService _filesService;
		private int _defaultTab = (int)MainTabsTypeCodes.DocumentsTab;
		private int _defaultRole = (int)AuthorizationRoleCodes.Operator;
		private int _hiddenUserDetailsId = 0;

		private IEnumerable<DocumentDTO> _allDocuments = null;

		private enum UsersDataGridActionCodes
		{
			EditUser = 4,
			DeleteUser = 5
		}

		private enum DocumentsDataGridActionCodes
		{
			ArchiveDocument = 3,
			DocumentDetails = 4,
			DeleteDocument = 5,
			OpenVersions = 6
		}
		
		private enum DocumentFilterTypeCodes
		{
			All = 0, 
			Active = 1,
			Arhived = 2
		}

		#endregion Fields

		#region Constructors

		public MainForm(FormsControlService formService)
		{
			_formsService = formService;
			_filesService = new FilesBusinessService();
			InitializeComponent();
			InitalizeHelp();
			
		}

		#endregion Constructors

		#region General

		private void MainForm_VisibleChanged(object sender, EventArgs e)
		{
			try
			{
				if (loggedUser == null) return;
				lblUsername.Text = loggedUser.DisplayName;
				this.tabControl.SelectTab(_defaultTab);
				InitializeDocumentsGrid();

				if (loggedUser.AuthorizationRole.Equals(AuthorizationRoleCodes.Operator))
				{
					_formsService.HideTabPage(this.tabControl, MainTabsTypeCodes.UsersTab);
					return;
				}
				if (loggedUser.AuthorizationRole.Equals(AuthorizationRoleCodes.Administrator))
				{
					_formsService.ShowTabPage(this.tabControl, MainTabsTypeCodes.UsersTab);
					return;
				}

				throw new NotSupportedException("AuthorizationRole");
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
			}
		}

		private void InitalizeHelp()
		{
			helpProvider.HelpNamespace = Properties.Settings.Default.HelpFileFullPath;
			toolTip.SetToolTip(this.txtBoxSearchExtension, "Biće prikazani dokumenti čija ekstenzija sadrži uneti pojam. Primer unosa: pdf");
			toolTip.SetToolTip(this.txtBoxSearchTitle, "Biće prikazani dokumenti čiji naziv sadrži uneti pojam");
			toolTip.SetToolTip(this.txtBoxSearchKeywords, "Razdvojiti ključne reči razmakom ili zarezom");

			toolTip.SetToolTip(this.chkBoxSearchExtensionActive, "Primenjuje pretragu po tipu fajla");
			toolTip.SetToolTip(this.chkBoxSearchKeywordsActive, "Primenjuje pretragu po ključnim rečima");
			toolTip.SetToolTip(this.chkBoxSearchTitleActive, "Primenjuje pretragu po naslovu");
			toolTip.SetToolTip(this.chkBoxSearchUserNameActive, "Pronalazi dokumente kojima izabrani korisnik može pristupiti");
			toolTip.SetToolTip(this.txtBoxSearchDocumentByUserName, "Pronalazi dokumente kojima izabrani korisnik može pristupiti");

			_formsService.SetHelpKeywordOnTextBoxes(helpProvider, this.documentsTab.Controls, "dokumenti");
			_formsService.SetHelpKeywordOnTextBoxes(helpProvider, this.myDataTab.Controls, "moji-podaci");
			_formsService.SetHelpKeywordOnTextBoxes(helpProvider, this.usersTab.Controls, "korisnici");
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			loggedUser = null;
			_formsService.ActivateForm(FormTypeCodes.LoginForm);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_formsService.Exit(e);
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				TabControl tab = (TabControl)sender;
				if (tab.SelectedIndex == (int)MainTabsTypeCodes.DocumentsTab)
				{
					InitializeDocumentsGrid();
					return;
				}
				if (tab.SelectedIndex == (int)MainTabsTypeCodes.MyDataTab)
				{
					RenderMyData();
					return;
				}
				if (tab.SelectedIndex == (int)MainTabsTypeCodes.UsersTab)
				{
					CancelUserSearch();
					LoadUsersDataGrid();
					return;
				}
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
				this.lblError.Text = "Došlo je do sistemske greške. Kontaktirajte administratora.";
			}
		}

		#endregion General

		#region MyData

		private void RenderMyData()
		{
			this.txtBoxTitle.Text = loggedUser.Title;
			this.txtBoxPhone.Text = loggedUser.ContactPhone;
			this.txtBoxOfficeNumber.Text = loggedUser.OfficeNumber;
			this.txtBoxEmail.Text = loggedUser.Email;
			this.txtBoxFirstName.Text = loggedUser.FirstName;
			this.txtBoxLastName.Text = loggedUser.LastName;
			this.lblAuthorizationRole.Text = String.Format("Prijavljeni ste kao {0}.", Enum.GetName(typeof(AuthorizationRoleCodes), loggedUser.AuthorizationRole).ToString());
			this.lblErrorContactInfo.Text = String.Empty;
			this.lblErrorPassword.Text = String.Empty;
		}

		private void btnSaveContactInfo_Click(object sender, EventArgs e)
		{
			if (Regex.Matches(this.txtBoxPhone.Text, @"[a-zA-Z]").Count > 0) return;
			if (Regex.Matches(this.txtBoxFirstName.Text, @"[0-9]").Count > 0) return;
			if (Regex.Matches(this.txtBoxLastName.Text, @"[0-9]").Count > 0) return;

			this.lblErrorContactInfo.Text = String.Empty;

			loggedUser.FirstName = this.txtBoxFirstName.Text;
			loggedUser.LastName = this.txtBoxLastName.Text;
			loggedUser.Email = this.txtBoxEmail.Text;
			loggedUser.ContactPhone = this.txtBoxPhone.Text;
			loggedUser.OfficeNumber = this.txtBoxOfficeNumber.Text;
			loggedUser.Title = this.txtBoxTitle.Text;
			_formsService.UsersService.UpdateUserDTO(loggedUser);

			_formsService.DisplayInformation("Promene su sačuvane");

		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(this.passwordTextBox1.Text) || String.IsNullOrEmpty(this.passwordTextBox2.Text))
			{
				this.lblErrorPassword.Text = "Podaci nisu ispravno uneti.";
				return;
			}
			if (!this.passwordTextBox1.Text.Equals(this.passwordTextBox2.Text))
			{
				this.lblErrorPassword.Text = "Lozinke se ne poklapaju.";
				return;
			}

			if (this.passwordTextBox1.Text.Length < AuthorizationBusinessService.PASSWORD_CHAR_MIN)
			{
				this.lblErrorPassword.Text = "Lozinka mora imati najmanje " + AuthorizationBusinessService.PASSWORD_CHAR_MIN + " karaktera.";
				return;
			}

			this.lblErrorPassword.Text = String.Empty;

			loggedUser.PasswordHash = new AuthorizationBusinessService().HashPassword(this.passwordTextBox1.Text);
			loggedUser.HasEmptyPassword = false;
			_formsService.UsersService.UpdateUserDTO(loggedUser);

			this.passwordTextBox1.Clear();
			this.passwordTextBox2.Clear();
			_formsService.DisplayInformation("Promene su sačuvane");
		}

		private void txtBoxFirstName_Validating(object sender, CancelEventArgs e)
		{
			if (Regex.Matches(this.txtBoxFirstName.Text, @"[0-9]").Count > 0)
			{
				errorProvider.SetError(this.txtBoxFirstName, "Ime ne može da sadrži slova.");
				return;
			}

			errorProvider.Clear();
		}

		private void txtBoxLastName_Validating(object sender, CancelEventArgs e)
		{
			if (Regex.Matches(this.txtBoxLastName.Text, @"[0-9]").Count > 0)
			{
				errorProvider.SetError(this.txtBoxLastName, "Prezime ne može da sadrži slova.");
				return;
			}

			errorProvider.Clear();
		}

		private void txtBoxPhone_Validating(object sender, CancelEventArgs e)
		{
			if (Regex.Matches(this.txtBoxPhone.Text, @"[a-zA-Z]").Count > 0)
			{
				errorProvider.SetError(this.txtBoxPhone, "Broj telefona nije ispravan.");
				return;
			}

			errorProvider.Clear();
		}

		#endregion MyData

		#region Users

		public void LoadUsersDataGrid(bool updateDataSource = true)
		{
			editUserPanel.Visible = false;
			panelUserSearch.Visible = true;
			usersGrid.Visible = true;
			btnAddNewUser.Visible = true;
			if (!updateDataSource) return;
			IList<UserDTO> users = _formsService.UsersService.LoadUsers().Where(u => u.Id != loggedUser.Id).ToList();

			userDTOBindingSource.Clear();
			if (users == null) return;
			foreach (UserDTO user in users)
			{
				userDTOBindingSource.Add(user);
			}
		}

		private void LoadUserDetails(UserDTO userDto)
		{
			editUserPanel.Visible = true;
			panelUserSearch.Visible = false;
			usersGrid.Visible = false;
			btnAddNewUser.Visible = false;
			btnResetPassword.Visible = false;
			tbUserDetailsUserName.ReadOnly = false;
			tbUserDetailsUserName.BackColor = Color.White;
			_hiddenUserDetailsId = 0;
			_formsService.ResetFormTextBoxes(editUserPanel.Controls);
			selectUserRole.Text = Enum.GetName(typeof(AuthorizationRoleCodes), _defaultRole);

			if (userDto != null)
			{
				tbUserDetailsContactPhone.Text = userDto.ContactPhone;
				tbUserDetailsEmail.Text = userDto.Email;
				tbUserDetailsFirstName.Text = userDto.FirstName;
				tbUserDetailsLastName.Text = userDto.LastName;
				tbUserDetailsOfficeNumber.Text = userDto.OfficeNumber;
				tbUserDetailsTitle.Text = userDto.Title;
				tbUserDetailsUserName.Text = userDto.UserName;
				tbUserDetailsUserName.ReadOnly = true;
				tbUserDetailsUserName.BackColor = Color.LightGray;
				selectUserRole.Text = Enum.GetName(typeof (AuthorizationRoleCodes), userDto.AuthorizationRole);
				btnResetPassword.Visible = true;
				_hiddenUserDetailsId = userDto.Id;
			}
		}

		private void usersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == (int) UsersDataGridActionCodes.DeleteUser)
			{

				if (MessageBox.Show("Da li ste sigurni da želite da obrišete korisnika?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					UserDTO user = (UserDTO)userDTOBindingSource[e.RowIndex];
					_formsService.UsersService.DeleteUser(user.Id);
					userDTOBindingSource.RemoveAt(e.RowIndex);
				}
				return;
			}
			if (e.ColumnIndex == (int) UsersDataGridActionCodes.EditUser)
			{
				UserDTO user = (UserDTO)userDTOBindingSource[e.RowIndex];
				LoadUserDetails(user);
				return;
			}
		}

		private void btnSaveUserChanges_Click(object sender, EventArgs e)
		{
			try
			{
				if (Regex.Matches(this.txtBoxFirstName.Text, @"[0-9]").Count > 0) return;
				if (Regex.Matches(this.txtBoxLastName.Text, @"[0-9]").Count > 0) return;
				if (Regex.Matches(this.tbUserDetailsContactPhone.Text, @"[a-zA-Z]").Count > 0) return;
				
				this.lblErrorUserDetails.Text = String.Empty;
				UserDTO userDto;
				if (_hiddenUserDetailsId == 0)
				{
					if (String.IsNullOrEmpty(this.tbUserDetailsUserName.Text)) return;
					if (_formsService.UsersService.CheckIfUserExists(this.tbUserDetailsUserName.Text)) return;

					userDto = new UserDTO();
				}
				else
				{
					userDto = _formsService.UsersService.LoadUserById(_hiddenUserDetailsId);
				}

				userDto.ContactPhone = tbUserDetailsContactPhone.Text;
				userDto.Email = tbUserDetailsEmail.Text;
				userDto.FirstName = tbUserDetailsFirstName.Text;
				userDto.LastName = tbUserDetailsLastName.Text;
				userDto.OfficeNumber = tbUserDetailsOfficeNumber.Text;
				userDto.Title = tbUserDetailsTitle.Text;
				userDto.UserName = tbUserDetailsUserName.Text;
				userDto.AuthorizationRole = (AuthorizationRoleCodes) Enum.Parse(typeof(AuthorizationRoleCodes), selectUserRole.Text, true);

				if (_hiddenUserDetailsId == 0)
				{
					userDto.HasEmptyPassword = true;
					userDto.IsValid = true;
					userDto.PasswordHash = String.Empty;
					_formsService.UsersService.SaveUserDTO(userDto);
				}
				else
				{
					_formsService.UsersService.UpdateUserDTO(userDto);
				}

				_formsService.DisplayInformation("Promene su sačuvane");

				_hiddenUserDetailsId = 0;
				LoadUsersDataGrid();
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
				this.lblErrorUserDetails.Text = "Došlo je do sistemske greške. Kontaktirajte administratora.";
			}
		}

		private void btnAddNewUser_Click(object sender, EventArgs e)
		{
			LoadUserDetails(null);
		}

		private void btnCancelUserChanges_Click(object sender, EventArgs e)
		{
			LoadUsersDataGrid(false);
		}

		private void btnResetPassword_Click(object sender, EventArgs e)
		{
			_formsService.UsersService.ResetUserPassword(_hiddenUserDetailsId);
			_formsService.DisplayInformation("Lozinka je resetovana.");
		}

		private void CancelUserSearch()
		{
			_formsService.ResetFormTextBoxes(panelUserSearch.Controls);
			btnCancelSearch.Visible = false;
			LoadUsersDataGrid();
		}

		private void btnCancelSearch_Click(object sender, EventArgs e)
		{
			CancelUserSearch();
		}

		private void btnPerformUserSearch_Click(object sender, EventArgs e)
		{
			UserFilterDTO filter = new UserFilterDTO();
			filter.UserName = txtBoxSearchUserName.Text;
			filter.FirstName = txtBoxSearchFirstName.Text;
			filter.LastName = txtBoxSearchLastName.Text;

			btnCancelSearch.Visible = true;

			IList<UserDTO> users = _formsService.UsersService.LoadFilteredUsers(filter).Where(u => u.Id != loggedUser.Id).ToList();

			userDTOBindingSource.Clear();
			if (users == null) return;
			foreach (UserDTO user in users)
			{
				userDTOBindingSource.Add(user);
			}
			
			LoadUsersDataGrid(false);
		}

		#region Validation

		private void tbUserDetailsUserName_Validating(object sender, CancelEventArgs e)
		{
			if (_hiddenUserDetailsId == 0)
			{
				if (String.IsNullOrEmpty(this.tbUserDetailsUserName.Text))
				{
					errorProvider.SetError(this.tbUserDetailsUserName, "Morate uneti korisničko ime.");
					return;
				}

				if (_formsService.UsersService.CheckIfUserExists(this.tbUserDetailsUserName.Text))
				{
					errorProvider.SetError(this.tbUserDetailsUserName, "Korisničko ime je zauzeto.");
					return;
				}
			}

			errorProvider.Clear();
		}

		private void tbUserDetailsFirstName_Validating(object sender, CancelEventArgs e)
		{
			if (Regex.Matches(this.tbUserDetailsFirstName.Text, @"[0-9]").Count > 0)
			{
				errorProvider.SetError(this.tbUserDetailsFirstName, "Ime ne može da sadrži slova.");
				return;
			}

			errorProvider.Clear();
		}

		private void tbUserDetailsLastName_Validating(object sender, CancelEventArgs e)
		{
			if (Regex.Matches(this.tbUserDetailsLastName.Text, @"[0-9]").Count > 0)
			{
				errorProvider.SetError(this.tbUserDetailsLastName, "Prezime ne može da sadrži slova.");
				return;
			}

			errorProvider.Clear();
		}

		private void tbUserDetailsContactPhone_Validating(object sender, CancelEventArgs e)
		{
			if (Regex.Matches(this.tbUserDetailsContactPhone.Text, @"[a-zA-Z]").Count > 0)
			{
				errorProvider.SetError(this.tbUserDetailsContactPhone, "Broj telefona nije ispravan.");
				return;
			}

			errorProvider.Clear();
		}

		#endregion Validation

		#endregion User

		#region Documents

		#region Documents Search

		private DocumentFilterDTO GreateDocumentFilter()
		{
			DocumentFilterDTO filter = new DocumentFilterDTO();
			if (chkBoxSearchTitleActive.Checked)
			{
				filter.Title = this.txtBoxSearchTitle.Text;
			}
			if (chkBoxSearchKeywordsActive.Checked)
			{
				filter.Keywords = this.txtBoxSearchKeywords.Text;
			}
			if (chkBoxSearchExtensionActive.Checked)
			{
				filter.Extension = this.txtBoxSearchExtension.Text;
			}
			if (panelSearchByUsers.Visible && chkBoxSearchUserNameActive.Checked)
			{
				filter.UserName = this.txtBoxSearchDocumentByUserName.Text;
			}

			filter.DateFrom = this.datePickerFrom.Value;
			filter.DateTo = this.datePickerTo.Value;

			if (this.selectDocumentsFilter.SelectedIndex == (int)DocumentFilterTypeCodes.Active)
			{
				filter.OnlyActive = true;
			}
			if (this.selectDocumentsFilter.SelectedIndex == (int)DocumentFilterTypeCodes.Arhived)
			{
				filter.OnlyArchived = true;
			}

			filter.LoggedUser = loggedUser;
			return filter;
		}

		private void InitalizeUsersAutoSuggest()
		{
			AutoCompleteStringCollection autoCompleteUsers = new AutoCompleteStringCollection();
			IEnumerable<string> userNames = _formsService.UsersService.LoadUsers().Select(u => u.UserName);
			autoCompleteUsers.AddRange(userNames.ToArray());
			txtBoxSearchDocumentByUserName.AutoCompleteCustomSource = autoCompleteUsers;
		}

		/// <summary>
		/// Resets all search filters of form on intialization and tab selection and do not invokes grid reload.
		/// </summary>
		private void ResetSearchFilters()
		{
			_formsService.ResetFormTextBoxes(this.documentsTab.Controls);
			selectDocumentsFilter.SelectedIndexChanged -= selectDocumentsFilter_SelectedIndexChanged;
			selectDocumentsFilter.SelectedIndex = 0;
			selectDocumentsFilter.SelectedIndexChanged += selectDocumentsFilter_SelectedIndexChanged;

			chkBoxSearchUserNameActive.CheckedChanged -= chkBoxSearchUserNameActive_CheckedChanged;
			chkBoxSearchUserNameActive.Checked = false;
			chkBoxSearchUserNameActive.CheckedChanged += chkBoxSearchUserNameActive_CheckedChanged;

			chkBoxSearchExtensionActive.CheckedChanged -= chkBoxSearchUserNameActive_CheckedChanged;
			chkBoxSearchExtensionActive.Checked = false;
			chkBoxSearchExtensionActive.CheckedChanged += chkBoxSearchUserNameActive_CheckedChanged;

			chkBoxSearchTitleActive.CheckedChanged -= chkBoxSearchUserNameActive_CheckedChanged;
			chkBoxSearchTitleActive.Checked = false;
			chkBoxSearchTitleActive.CheckedChanged += chkBoxSearchUserNameActive_CheckedChanged;

			chkBoxSearchKeywordsActive.CheckedChanged -= chkBoxSearchUserNameActive_CheckedChanged;
			chkBoxSearchKeywordsActive.Checked = false;
			chkBoxSearchKeywordsActive.CheckedChanged += chkBoxSearchUserNameActive_CheckedChanged;
			ResetDatePicker();

		}

		private void ResetDatePicker()
		{
			if (_allDocuments != null && _allDocuments.Count() > 0)
			{
				datePickerFrom.ValueChanged -= datePickerFrom_ValueChanged;
				datePickerTo.ValueChanged -= datePickerTo_ValueChanged;
				datePickerFrom.Value = _allDocuments.First().CreatedAt;
				datePickerTo.Value = _allDocuments.Last().CreatedAt;
				datePickerFrom.ValueChanged += datePickerFrom_ValueChanged;
				datePickerTo.ValueChanged += datePickerTo_ValueChanged;
			}
		}

		private void chkBoxSearchTitleActive_CheckedChanged(object sender, EventArgs e)
		{
			LoadDocumentsGrid();
		}

		private void chkBoxSearchKeywordsActive_CheckedChanged(object sender, EventArgs e)
		{
			LoadDocumentsGrid();
		}

		private void chkBoxSearchExtensionActive_CheckedChanged(object sender, EventArgs e)
		{
			LoadDocumentsGrid();
		}

		private void selectDocumentsFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadDocumentsGrid();
		}

		private void chkBoxSearchUserNameActive_CheckedChanged(object sender, EventArgs e)
		{
			LoadDocumentsGrid();
		}

		private void datePickerFrom_ValueChanged(object sender, EventArgs e)
		{
			DateTimePicker pickerFrom = (DateTimePicker) sender;
			if (pickerFrom.Value > this.datePickerTo.Value)
			{
				ResetDatePicker();
			}

			LoadDocumentsGrid();
		}

		private void datePickerTo_ValueChanged(object sender, EventArgs e)
		{
			DateTimePicker pickerTo = (DateTimePicker)sender;
			if (pickerTo.Value < this.datePickerFrom.Value)
			{
				ResetDatePicker();
			}

			LoadDocumentsGrid();
		}

		#endregion Documents Search

		#region Paging

		private int _documentsPerPage = Properties.Settings.Default.DocumentsPerPage;
		private int _currentPage = 0;
		
		public void SetUpPagerFormat(int resultsOnPage, int numberOfResults)
		{
			int numOfPages = numberOfResults / _documentsPerPage;
			this.lblDocumentsPaginatorInfo.Text = String.Format("strana {0} od {1} | prikazano {2} od ukupno {3} dokumenta", _currentPage + 1, numOfPages + 1, resultsOnPage, numberOfResults);
			if (numberOfResults == 0) this.lblDocumentsPaginatorInfo.Text = String.Empty;
		}

		private IEnumerable<DocumentDTO> PreparePagedList()
		{
			if (_allDocuments == null) return null;
			return _allDocuments.Skip(_currentPage * _documentsPerPage).Take(_documentsPerPage);
		}

		private void btnDocumentsNextPage_Click(object sender, EventArgs e)
		{
			if (_currentPage + 1 > _allDocuments.Count() / _documentsPerPage) return;
			_currentPage++;
			LoadDocumentsGrid();
		}

		private void btnDocumentsPrevPage_Click(object sender, EventArgs e)
		{
			if (_currentPage < 1) return;
			_currentPage--;
			LoadDocumentsGrid();
		}

		#endregion Paging

		public void InitializeDocumentsGrid()
		{
			// HACK: load all documents before control initialization, since datetimepicker does not support null value :(.
			datePickerFrom.ValueChanged -= datePickerFrom_ValueChanged;
			datePickerTo.ValueChanged -= datePickerTo_ValueChanged;
			datePickerFrom.Value = DateTime.Now.AddYears(-10).Date;
			datePickerTo.Value = DateTime.Now.AddYears(10).Date;
			datePickerFrom.ValueChanged += datePickerFrom_ValueChanged;
			datePickerTo.ValueChanged += datePickerTo_ValueChanged;
			
			this.panelSearchByUsers.Visible = true;
			this.lblError.Text = String.Empty;
			if (loggedUser.AuthorizationRole == AuthorizationRoleCodes.Operator)
			{
				this.panelSearchByUsers.Visible = false;
			}

			_currentPage = 0;
			LoadDocumentsGrid();
			ResetSearchFilters();
			InitalizeUsersAutoSuggest();
		}

		public void LoadDocumentsGrid(bool updateDataSource = true)
		{
			try
			{
				if (!updateDataSource) return;
				_allDocuments = _formsService.DocumentsService.LoadUserDocuments(GreateDocumentFilter()).ToList();

				documentDTOBindingSource.Clear();
				if (_allDocuments == null) return;

				IEnumerable<DocumentDTO> paggedDocuments = PreparePagedList();
				foreach (DocumentDTO document in paggedDocuments)
				{
					documentDTOBindingSource.Add(document);
				}

				SetUpPagerFormat(paggedDocuments.Count(), _allDocuments.Count());
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
				this.lblError.Text = "Došlo je do sistemske greške. Kontaktirajte administratora.";
			}
		}

		private void documentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.ColumnIndex == (int)DocumentsDataGridActionCodes.ArchiveDocument)
				{
					DocumentDTO document = (DocumentDTO)documentDTOBindingSource[e.RowIndex];
					if (!_formsService.DocumentsService.CheckIfUserHasWriteAccess(loggedUser.Id, document.Id))
					{
						this.lblError.Text = "Nemate odgovarajuća prava pristupa.";
						documentDTOBindingSource[e.RowIndex] = _allDocuments.Where(u => u.Id == document.Id).Single();
						return;
					}

					documentDTOBindingSource[e.RowIndex] = _formsService.DocumentsService.ToggleArchivedFlag(_allDocuments.Where(u => u.Id == document.Id).Single());
					return;
				}
				if (e.ColumnIndex == (int)DocumentsDataGridActionCodes.DeleteDocument)
				{
					DocumentDTO document = (DocumentDTO)documentDTOBindingSource[e.RowIndex];
					if (!_formsService.DocumentsService.CheckIfUserHasWriteAccess(loggedUser.Id, document.Id))
					{
						this.lblError.Text = "Nemate odgovarajuća prava pristupa.";
						return;
					}

					if (MessageBox.Show("Da li ste sigurni da želite da obrišete dokument?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						_formsService.DocumentsService.DeleteDocument(document.Id);
						documentDTOBindingSource.RemoveAt(e.RowIndex);
					}
					return;
				}
				if (e.ColumnIndex == (int)DocumentsDataGridActionCodes.DocumentDetails)
				{
					DocumentDTO document = (DocumentDTO)documentDTOBindingSource[e.RowIndex];
					LoadDocumentDetails(document);
				}
				if (e.ColumnIndex == (int)DocumentsDataGridActionCodes.OpenVersions)
				{
					DocumentDTO document = (DocumentDTO)documentDTOBindingSource[e.RowIndex];
					LoadDocumentVersions(document);
				}
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
				this.lblError.Text = "Došlo je do sistemske greške. Kontaktirajte administratora.";
			}
		}

		private void btnAddDocument_Click(object sender, EventArgs e)
		{
			_formsService.ActivateForm(FormTypeCodes.DocumentDetailsForm);
		}

		private void LoadDocumentDetails(DocumentDTO document)
		{
			if (document == null) throw new ArgumentNullException("document");
			DocumentDetailsForm form = (DocumentDetailsForm)_formsService.GetFormByCode(FormTypeCodes.DocumentDetailsForm);
			form.documentDto = document;
			_formsService.ActivateForm(FormTypeCodes.DocumentDetailsForm);
		}

		private void LoadDocumentVersions(DocumentDTO document)
		{
			if (document == null) throw new ArgumentNullException("document");

			DocumentVersionsForm form = (DocumentVersionsForm) _formsService.GetFormByCode(FormTypeCodes.DocumentVersionsForm);
			form.documentDto = document;
			_formsService.ActivateForm(FormTypeCodes.DocumentVersionsForm);
		}

		#endregion Documents

		#region Help Events

		private void btnOpenDocumentsHelp_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(documentsTab, helpProvider.HelpNamespace);
		}

		private void documentsTab_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
			{
				Help.ShowHelp(documentsTab, helpProvider.HelpNamespace);
			}
		}

		private void btnOpenMyDataHelp_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(myDataTab, helpProvider.HelpNamespace);
		}

		private void myDataTab_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
			{
				Help.ShowHelp(myDataTab, helpProvider.HelpNamespace);
			}
		}

		private void btnUsersOpenHelp_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(usersTab, helpProvider.HelpNamespace);
		}

		private void btnUsersOpenHelp_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
			{
				Help.ShowHelp(usersTab, helpProvider.HelpNamespace);
			}
		}

		private void btnOpenMyDataHelp_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
			{
				Help.ShowHelp(myDataTab, helpProvider.HelpNamespace);
			}
		}

		private void btnOpenMyDataHelp_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
			{
				Help.ShowHelp(myDataTab, helpProvider.HelpNamespace);
			}
		}

		private void panel3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
			{
				Help.ShowHelp(myDataTab, helpProvider.HelpNamespace);
			}
		}

		#endregion Help Events

	}
}
