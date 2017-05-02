using DMS.DTO;
using DMS.Exceptions;
using DMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DMS
{
	public partial class DocumentDetailsForm : Form
	{
		#region Felds

		private enum DocumentShareTypeCodes
		{
			ReadOnly = 0,
			ReadWrite = 1
		}

		protected internal DocumentDTO documentDto = null;
		private IList<DocumentShareDTO> _sharedWith = null;
		private FormsControlService _formsService;
		private FilesBusinessService _filesService;
		private int _defaultShareType = (int)DocumentShareTypeCodes.ReadOnly;
		private bool _isFormEditable = false;
		private KeyValuePair<string, string>? _fileDetailsKvp = null;

		#endregion Fields

		public DocumentDetailsForm(FormsControlService formService)
		{
			_formsService = formService;
			_filesService = new FilesBusinessService();
			InitializeComponent();
			_formsService.InitalizeFormHelpProvider(helpProvider, this, "dokument");
			this.Size = new Size(777, 405);
		}

		#region Helpers

		private static Func<DocumentAccessRightCodes, string> formatLocalAccessCodesName = (code) =>
		{
			switch (code)
			{
				case DocumentAccessRightCodes.Owner: return "Vlasnik";
				case DocumentAccessRightCodes.Modify: return "Čitanje i pisanje";
				default: return "Čitanje";
			}
		};

		private static Func<string, DocumentAccessRightCodes, string> formatBoxItem = (s, code) => s.ToString() + " - " + formatLocalAccessCodesName(code);

		#endregion Helpers

		#region Render

		public void SetNewDocumentView()
		{
			this.panelAddFile.Show();
			this.panelOpen.Hide();
			this.panelCloseRead.Hide();
			this.panelCloseWrite.Hide();
			FormatFileInfo();
			this.txtBoxTitle.Text = String.Empty;
			this.boxKeywords.Items.Clear();
			this.boxSharedUsers.Items.Clear();
		}

		public void SetOpenedForReadView()
		{
			this.panelAddFile.Hide();
			this.panelOpen.Hide();
			this.panelCloseRead.Show();
			this.panelCloseWrite.Hide();
			this.panelCloseRead.Location = new Point(15, 289);
		}

		public void SetOpenedForWriteView()
		{
			this.panelAddFile.Hide();
			this.panelOpen.Hide();
			this.panelCloseWrite.Show();
			this.panelCloseRead.Hide();
			this.panelCloseWrite.Location = new Point(15, 289);
		}

		public void SetClosedView()
		{
			this.panelAddFile.Hide();
			this.panelOpen.Show();
			this.panelCloseWrite.Hide();
			this.panelCloseRead.Hide();
			this.panelOpen.Location = new Point(15, 289);
		}

		private void FormatInfoText()
		{
			if (documentDto != null)
			{
				string lastModAt = documentDto.CreatedAt.Date.ToShortDateString();
				if (documentDto.LastModifiedAt.HasValue)
				{
					lastModAt = documentDto.LastModifiedAt.Value.Date.ToShortDateString();
				}
				this.lblInfo.Text = String.Format("Dokument {0} dodat je {1} \nposlednja izmena napravljena je: {2}.", documentDto.FullName, documentDto.CreatedAt.Date.ToShortDateString(), lastModAt);
			}
			else
			{
				this.lblInfo.Text = String.Format("Unesite osnovne podatke i priložite dokument");
			}
		}

		private void InitalizeFormView()
		{
			FormatInfoText();
			if (!_isFormEditable)
			{
				txtBoxTitle.ReadOnly = true;
				txtBoxTitle.BackColor = Color.LightGray;
				txtBoxKeyword.ReadOnly = true;
				txtBoxKeyword.BackColor = Color.LightGray;
				txtBoxUserName.ReadOnly = true;
				txtBoxUserName.BackColor = Color.LightGray;
				boxKeywords.BackColor = Color.LightGray;
				boxSharedUsers.BackColor = Color.LightGray;
			}
			else
			{
				txtBoxTitle.ReadOnly = false;
				txtBoxTitle.BackColor = Color.White;
				txtBoxKeyword.ReadOnly = false;
				txtBoxKeyword.BackColor = Color.White;
				txtBoxUserName.ReadOnly = false;
				txtBoxUserName.BackColor = Color.White;
				boxKeywords.BackColor = Color.White;
				boxSharedUsers.BackColor = Color.White;
			}

			this.toolTip.SetToolTip(this.txtBoxKeyword, "Ključne reči omogućavaju lakši pronalazak dokumenta");
			this.toolTip.SetToolTip(this.boxKeywords, "Ključne reči omogućavaju lakši pronalazak dokumenta");
			this.toolTip.SetToolTip(this.btnAddKeyword, "Ključne reči omogućavaju lakši pronalazak dokumenta");
		}

		public void FormatFileInfo(string fileName = null)
		{
			if (String.IsNullOrEmpty(fileName))
			{
				this.lblAddedFileInfo.Text = "Nije priložen fajl.";
			}
			else
			{
				this.lblAddedFileInfo.Text = String.Format("Priložen je fajl: {0}", fileName);
			}
		}

		#endregion Render

		#region Keywords

		private void LoadDocumentKeywords()
		{
			boxKeywords.Items.Clear();
			if (documentDto == null) return;
			boxKeywords.Items.AddRange(_formsService.DocumentsService.LoadDocumentKeywords(documentDto.Id).ToArray());
		}

		private void btnAddKeyword_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(txtBoxKeyword.Text)) return;
			if (!_isFormEditable) return;
			boxKeywords.Items.Add(txtBoxKeyword.Text);
			txtBoxKeyword.Text = String.Empty;
		}

		private void btnRemoveKeywords_Click(object sender, EventArgs e)
		{
			if (!_isFormEditable) return;
			for (int i = boxKeywords.SelectedIndices.Count - 1; i >= 0; i--)
			{
				boxKeywords.Items.RemoveAt(boxKeywords.SelectedIndices[i]);
			}
		}

		#endregion Keywords

		#region Document Sharing

		private void InitializeUsersAutoComplete()
		{
			if (!_isFormEditable) return;
			AutoCompleteStringCollection autoCompleteUsers = new AutoCompleteStringCollection();
			IEnumerable<string> userNames = _formsService.UsersService.LoadUsersForShareAutosuggest(documentDto, _formsService.GetLoggedUser().Id).Select(u => u.UserName);
			autoCompleteUsers.AddRange(userNames.ToArray());
			txtBoxUserName.AutoCompleteCustomSource = autoCompleteUsers;
		}
		
		private void LoadDocumentSharing()
		{
			selectShareType.SelectedIndex = _defaultShareType;
			InitializeUsersAutoComplete();
			boxSharedUsers.Items.Clear();
			_sharedWith = new List<DocumentShareDTO>();

			if (documentDto == null) return;
			long loggedId = _formsService.GetLoggedUser().Id;

			_sharedWith = _formsService.DocumentsService.LoadDocumentsShare(documentDto.Id).Where(u => u.UserId != loggedId).ToList();
			boxSharedUsers.Items.AddRange(_sharedWith.Select(u => formatBoxItem(u.UserName, u.AccessRight)).ToArray()); 
		}

		private void btnShare_Click(object sender, EventArgs e)
		{
			try
			{
				if (!_isFormEditable) return;
				if (String.IsNullOrEmpty(txtBoxUserName.Text)) return;
				this.lblError.Text = String.Empty;

				string [] userNames = _formsService.UsersService.LoadUsersForShareAutosuggest(documentDto, _formsService.GetLoggedUser().Id).Select(u => u.UserName).ToArray();
				if (!userNames.Contains(this.txtBoxUserName.Text))
				{
					this.lblError.Text = "Korisničko ime nije ispravno.";
					return;
				}

				DocumentShareDTO doc = new DocumentShareDTO()
				{
					UserName = txtBoxUserName.Text,
					UserId = _formsService.UsersService.LoadUserByName(txtBoxUserName.Text).Id,
					AccessRight = (DocumentAccessRightCodes)selectShareType.SelectedIndex + 1
				};
				_sharedWith.Add(doc);
				boxSharedUsers.Items.Add(formatBoxItem(doc.UserName, doc.AccessRight));
				txtBoxUserName.Text = String.Empty;
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
				this.lblError.Text = "Došlo je do sistemske greške. Kontaktirajte administratora.";
			}
		}

		private void btnRemoveShares_Click(object sender, EventArgs e)
		{
			if (!_isFormEditable) return;
			for (int i = boxSharedUsers.SelectedIndices.Count - 1; i >= 0; i--)
			{
				int index = boxSharedUsers.SelectedIndices[i];
				boxSharedUsers.Items.RemoveAt(index);
				_sharedWith.RemoveAt(index);
			}
		}

		#endregion Document Sharing

		#region Metadata Edit

		private void CreateOrUpdateDocument()
		{
			try
			{
				this.lblError.Text = String.Empty;
				if (String.IsNullOrEmpty(this.txtBoxTitle.Text)) return;

				if (documentDto == null)
				{
					if (!_fileDetailsKvp.HasValue)
					{
						this.lblError.Text = "Morate priložiti fajl.";
						return;
					}
					
					documentDto = new DocumentDTO();
				}

				documentDto.Title = txtBoxTitle.Text;
				documentDto.Keywords = new List<KeywordDTO>();

				foreach (object obj in boxKeywords.Items)
				{
					string value = obj as string;
					if (!String.IsNullOrEmpty(value))
					{
						documentDto.Keywords.Add(new KeywordDTO(){ Name = value });
					}
				}

				documentDto.DocumentShares = _sharedWith;

				if (documentDto.Id > 0)
				{
					_formsService.DocumentsService.UpdateDocumentData(documentDto, _formsService.GetLoggedUser().Id);
				}
				else
				{
					documentDto.Extension = _fileDetailsKvp.Value.Value;
					documentDto = _formsService.DocumentsService.SaveNewDocument(documentDto, _formsService.GetLoggedUser().Id);

					string newPath = _formsService.DocumentsService.AddNewDocumentVersion(documentDto);
					_filesService.SaveFileToServer(_fileDetailsKvp.Value.Key, newPath);
				}

				_formsService.ActivateForm(FormTypeCodes.MainForm);
				documentDto = null;
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
				this.lblError.Text = "Došlo je do sistemske greške. Kontaktirajte administratora.";
				documentDto = null;
			}
		}

		private void btnDocumentDetailsSave_Click(object sender, EventArgs e)
		{
			this.lblError.Text = String.Empty;
			if (!_isFormEditable)
			{
				if (documentDto.IsArchived)
				{
					this.lblError.Text = "Dokument je arhiviran.";
				}
				else
				{
					this.lblError.Text = "Nemate odgovarajuća prava pristupa.";
				}
				return;
			}

			CreateOrUpdateDocument();
		}

		#endregion Metadata Edit

		private void DocumentDetailsForm_VisibleChanged(object sender, EventArgs e)
		{
			try
			{
				UserDTO loggedUser = _formsService.GetLoggedUser();
				if (loggedUser == null) throw new AuthorizationException();
				
				this.lblError.Text = String.Empty;

				if (documentDto == null)
				{
					_isFormEditable = true;
					SetNewDocumentView();
					InitalizeFormView();
					LoadDocumentSharing();
					return;
				}

				if (_formsService.DocumentsService.CheckIfUserHasWriteAccess(loggedUser.Id, documentDto.Id))
				{
					_isFormEditable = true;
				}
				else
				{
					_isFormEditable = false;
				}

				if (documentDto.IsArchived)
				{
					_isFormEditable = false;
				}

				txtBoxTitle.Text = documentDto.Title;
				InitalizeFormView();
				LoadDocumentKeywords();
				LoadDocumentSharing();

				if (_formsService.DocumentsService.IsUserWritingToDocument(loggedUser.Id, documentDto.Id))
				{
					SetOpenedForWriteView();
					return;
				}

				if (_formsService.DocumentsService.IsUserReadingFromDocument(loggedUser.Id, documentDto.Id))
				{
					SetOpenedForReadView();
					return;
				}

				SetClosedView();
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
				this.lblError.Text = "Došlo je do sistemske greške. Kontaktirajte administratora.";
			}
		}

		private void DocumentDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_formsService.Exit(e);
		}

		#region Open and Close

		private void btnCancelDocumentDetails_Click(object sender, EventArgs e)
		{
			documentDto = null;
			_formsService.ActivateForm(FormTypeCodes.MainForm);
		}

		private void btnOpenForRead_Click(object sender, EventArgs e)
		{
			this.lblError.Text = String.Empty;

			if (!_formsService.DocumentsService.TryOpenDocumentForReading(documentDto.Id, _formsService.GetLoggedUser().Id))
			{
				this.lblError.Text = "Drugi korisnik trenutno piše nad ovim dokumentom.";
				return;
			}

			saveFileDialog.FileName = documentDto.Title;
			saveFileDialog.Filter = String.Format("Dokument (*.{0})|*.{0}", documentDto.Extension);

			DialogResult result = saveFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				string filePath = _formsService.DocumentsService.GetLastDocumentVersionFilePath(documentDto.Id);
				_filesService.LoadFileFromServer(filePath, saveFileDialog.FileName);

				SetOpenedForReadView();
			} 
		}

		private void btnOpenForWrite_Click(object sender, EventArgs e)
		{
			if (!_formsService.DocumentsService.CheckIfUserHasWriteAccess(_formsService.GetLoggedUser().Id, documentDto.Id))
			{
				this.lblError.Text = "Nemate odgovarajuća prava pristupa.";
				return;
			}

			if (!_formsService.DocumentsService.TryOpenDocumentForWriting(documentDto.Id, _formsService.GetLoggedUser().Id))
			{
				this.lblError.Text = "Drugi korisnik trenutno pristupa ovom dokumentu.";
				return;
			}

			saveFileDialog.FileName = documentDto.Title;
			saveFileDialog.Filter = String.Format("Dokument (*.{0})|*.{0}", documentDto.Extension);

			DialogResult result = saveFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				string filePath = _formsService.DocumentsService.GetLastDocumentVersionFilePath(documentDto.Id);
				_filesService.LoadFileFromServer(filePath, saveFileDialog.FileName);
				SetOpenedForWriteView();
			} 
		}

		private void btnCloseWr_Click(object sender, EventArgs e)
		{
			_formsService.DocumentsService.CloseDocument(documentDto.Id, _formsService.GetLoggedUser().Id);
			SetClosedView();
		}

		private void btnCloseRd_Click(object sender, EventArgs e)
		{
			_formsService.DocumentsService.CloseDocument(documentDto.Id, _formsService.GetLoggedUser().Id);
			SetClosedView();
		}

		private void btnSaveWriting_Click(object sender, EventArgs e)
		{
			DialogResult result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				documentDto.Extension = Path.GetExtension(openFileDialog.FileName);

				string newPath = _formsService.DocumentsService.AddNewDocumentVersion(documentDto);
				_filesService.SaveFileToServer(openFileDialog.FileName, newPath); 

				_formsService.DocumentsService.CloseDocument(documentDto.Id, _formsService.GetLoggedUser().Id);
				SetClosedView();
			}
		}

		private void btnAddFile_Click(object sender, EventArgs e)
		{
			DialogResult result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK) 
			{
				string extension = Path.GetExtension(openFileDialog.FileName);
				_fileDetailsKvp = new KeyValuePair<string, string>(openFileDialog.FileName, extension);
				FormatFileInfo(openFileDialog.FileName);
			}
		}

		#endregion Open and Close

		private void txtBoxTitle_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(this.txtBoxTitle.Text))
			{
				errorProvider.SetError(this.txtBoxTitle, "Naslov dokumenta je obavezan podatak.");
				return;
			}
			errorProvider.Clear();
		}

		private void helpToolStripHelpItem_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, helpProvider.HelpNamespace);
		}
	}
}
