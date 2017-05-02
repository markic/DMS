using DMS.Services;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DMS
{
	public partial class NewPasswordForm : Form
	{
		#region Fields

		private FormsControlService _formsService;

		#endregion Fields
		
		public NewPasswordForm(FormsControlService formsService)
		{
			_formsService = formsService;
			InitializeComponent();
			_formsService.InitalizeFormHelpProvider(helpProvider, this, "nova-lozinka");
		}

		private void NewPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_formsService.Exit(e);
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(this.passwordTextBox1.Text) || String.IsNullOrEmpty(this.passwordTextBox2.Text)) return;
			if (!this.passwordTextBox1.Text.Equals(this.passwordTextBox2.Text)) return;
			if (this.passwordTextBox1.Text.Length < AuthorizationBusinessService.PASSWORD_CHAR_MIN) return;

			this.lblError.Text = String.Empty;

			LoginForm loginForm = (LoginForm)_formsService.GetFormByCode(FormTypeCodes.LoginForm);

			string hash = new AuthorizationBusinessService().HashPassword(this.passwordTextBox1.Text);
			MainForm mainForm = (MainForm)_formsService.GetFormByCode(FormTypeCodes.MainForm);

			mainForm.loggedUser = _formsService.UsersService.SaveUserPassword(loginForm.GetUserName.Text, hash);

			_formsService.ResetFormTextBoxes(this.Controls);
			_formsService.ActivateForm(FormTypeCodes.MainForm);
			_formsService.ResetFormTextBoxes(loginForm.Controls);
		}

		private void passwordTextBox1_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(this.passwordTextBox1.Text))
			{
				errorProvider.SetError(this.passwordTextBox1, "Morate uneti lozinku.");
				return;
			}

			if (this.passwordTextBox1.Text.Length < AuthorizationBusinessService.PASSWORD_CHAR_MIN)
			{
				errorProvider.SetError(this.passwordTextBox1, "Lozinka mora imati najmanje " + AuthorizationBusinessService.PASSWORD_CHAR_MIN + " karaktera.");
				return;
			}

			errorProvider.Clear();
		}

		private void passwordTextBox2_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(this.passwordTextBox2.Text))
			{
				errorProvider.SetError(this.passwordTextBox2, "Morate uneti lozinku.");
				return;
			}
			
			if (!this.passwordTextBox1.Text.Equals(this.passwordTextBox2.Text))
			{
				errorProvider.SetError(this.passwordTextBox2, "Lozinke se ne poklapaju.");
				return;
			}
			
			errorProvider.Clear();
		}

		private void helpToolStripHelpItem_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, helpProvider.HelpNamespace);
		}

		#region Validation



		#endregion Validation
	}
}
