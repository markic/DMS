using DMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMS.Services
{

	public enum FormTypeCodes
	{
		LoginForm = 1,
		RegisterForm = 2,
		NewPasswordForm = 3,
		MainForm = 4,
		DocumentDetailsForm = 5,
		DocumentVersionsForm = 6
	}

	public enum MainTabsTypeCodes
	{
		DocumentsTab = 0,
		MyDataTab = 1,
		UsersTab = 2
	}
	
	public class FormsControlService
	{
		#region Fields

		private IList<Form> _forms;
		private bool _finished = false;
		private TabPage _hidenTabPane = null;
		private UsersBusinessService _usersService;
		private DocumentsBusinessService _documentsService;

		#endregion Fields

		#region Properties

		protected internal UsersBusinessService UsersService
		{
			get { return _usersService; }
		}

		protected internal DocumentsBusinessService DocumentsService
		{
			get { return _documentsService; }
		}

		#endregion Properties

		#region Constructors

		public FormsControlService()
		{
			_usersService = new UsersBusinessService();
			_documentsService = new DocumentsBusinessService();
			_forms = new List<Form>();
			_forms.Add(new MainForm(this));
			_forms.Add(new LoginForm(this));
			_forms.Add(new RegisterForm(this));
			_forms.Add(new NewPasswordForm(this));
			_forms.Add(new DocumentDetailsForm(this));
			_forms.Add(new DocumentVersionsForm(this));
		}

		#endregion Constructors

		#region Methods

		public void ActivateForm(FormTypeCodes code)
		{
			string name = Enum.GetName(typeof(FormTypeCodes), (Object) code);

			foreach (Form form in _forms)
			{
				form.Visible = false;
			}

			Form destForm = _forms.Where(u => u.Name.Equals(name)).Single();
			destForm.Visible = true;
		}

		public Form GetFormByCode(FormTypeCodes code)
		{
			string name = Enum.GetName(typeof(FormTypeCodes), (Object)code);
			return _forms.Where(u => u.Name.Equals(name)).Single();
		}

		public void Exit(FormClosingEventArgs e)
		{
			if (_finished) return;
			if (MessageBox.Show("Da li ste sigurni da želite da ugasite program?", "Kraj rada", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				_finished = true;
				Application.Exit();
			}
			e.Cancel = true;
		}

		public void ResetFormTextBoxes(Control.ControlCollection controls)
		{
			foreach (Control control in controls)
			{
				TextBox tb = control as TextBox;
				if (tb != null) tb.Clear();
				else ResetFormTextBoxes(control.Controls);
			}
		}

		public void InitalizeFormHelpProvider(HelpProvider helpProvider, Form form, string keyword)
		{
			helpProvider.HelpNamespace = Properties.Settings.Default.HelpFileFullPath;
			SetHelpKeywordOnTextBoxes(helpProvider, form.Controls, keyword);
		}

		public void SetHelpKeywordOnTextBoxes(HelpProvider helpProvider, Control.ControlCollection controls, string keyword)
		{
			if (controls == null) return;

			foreach (Control control in controls)
			{
				helpProvider.SetHelpNavigator(control, System.Windows.Forms.HelpNavigator.KeywordIndex);
				helpProvider.SetHelpKeyword(control, keyword);
				helpProvider.SetShowHelp(control, true);

				if (control.Controls != null && control.Controls.Count > 0)
					SetHelpKeywordOnTextBoxes(helpProvider, control.Controls, keyword);
			}
		}

		public void HideTabPage(TabControl control, MainTabsTypeCodes code)
		{
			if (_hidenTabPane != null) return;
			_hidenTabPane = control.TabPages[(int)code];
			control.TabPages.RemoveAt((int)code);
		}

		public void ShowTabPage(TabControl control, MainTabsTypeCodes code)
		{
			if (_hidenTabPane == null) return;
			control.TabPages.Insert((int) code, _hidenTabPane);
			_hidenTabPane = null;
		}

		public void DisplayInformation(string message)
		{
			MessageBox.Show(message, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public string FormatDateTime(DateTime? dateTime)
		{
			if (!dateTime.HasValue) return String.Empty;
			StringBuilder result = new StringBuilder();
			result.Append(dateTime.Value.ToShortDateString());
			result.Append(" u ");
			result.Append(dateTime.Value.ToShortTimeString());
			result.Append(" h");
			return result.ToString();
		}

		public UserDTO GetLoggedUser()
		{
			MainForm form = (MainForm) GetFormByCode(FormTypeCodes.MainForm);
			return form.loggedUser;
		}

		#endregion Methods
	}
}
