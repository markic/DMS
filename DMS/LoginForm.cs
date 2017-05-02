using System;
using System.ComponentModel;
using System.Windows.Forms;
using DMS.Services;
using DMS.DTO;
using DMS.Exceptions;

namespace DMS
{
	public partial class LoginForm : Form
	{
		#region Fields
		
		private AuthorizationBusinessService _authorizationService;
		private FormsControlService _formsService;
		private UserDTO _user;

		#endregion Fields

		#region Constructor

		public LoginForm(FormsControlService formService)
		{
			_authorizationService = new AuthorizationBusinessService();
			_formsService = formService;
			InitializeComponent();
			_formsService.InitalizeFormHelpProvider(helpProvider, this, "prijava");
		}

		#endregion Constructor

		private void TryToLogin()
		{
			try
			{
				if (String.IsNullOrEmpty(this.UserName.Text)) return;

				_user = _formsService.UsersService.LoadUserByName(this.UserName.Text);

				if (_user.HasEmptyPassword && this.Password.Text.Equals(""))
				{
					_formsService.ActivateForm(FormTypeCodes.NewPasswordForm);
					this.lblError.Text = String.Empty;
					return;
				}

				if (String.IsNullOrEmpty(this.Password.Text))
				{
					this.lblError.Text = String.Format("Morate uneti lozinku.");
					return;
				}

				string inputHash = _authorizationService.HashPassword(this.Password.Text);

				if (inputHash.Equals(_user.PasswordHash))
				{
					MainForm mainForm = (MainForm)_formsService.GetFormByCode(FormTypeCodes.MainForm);
					mainForm.loggedUser = _user;
					_formsService.ActivateForm(FormTypeCodes.MainForm);

					_formsService.ResetFormTextBoxes(this.Controls);
					this.lblError.Text = String.Empty;
					return;
				}

				this.lblError.Text = String.Format("Uneta lozinka nije ispravna.");
			}
			catch (UserNotFoundException ex)
			{
				this.lblError.Text = String.Format("{0}'{1}'.", ex.Message, this.UserName.Text);
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex);
				this.lblError.Text = "Došlo je do sistemske greške. Kontaktirajte administratora.";
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			TryToLogin();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			_formsService.ResetFormTextBoxes(Controls);
			_formsService.ActivateForm(FormTypeCodes.RegisterForm);
		}

		private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_formsService.Exit(e);
		}

		#region Validation

		private void UserName_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(this.UserName.Text))
			{
				errorProvider.SetError(this.UserName, "Morate uneti korisničko ime.");
			}
			else
			{
				errorProvider.Clear();
			}
		}

		#endregion Validation

		private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, helpProvider.HelpNamespace);
		}

		private void LoginForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				TryToLogin();
			}
		}
	}
}
