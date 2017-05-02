using DMS.DTO;
using DMS.Services;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DMS
{
	public partial class RegisterForm : Form
	{
		private FormsControlService _formsService;

		public RegisterForm(FormsControlService formsService)
		{
			_formsService = formsService;
			InitializeComponent();
			_formsService.InitalizeFormHelpProvider(helpProvider, this, "registracija");
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			lblError.Text = String.Empty;
			_formsService.ResetFormTextBoxes(this.Controls);
			_formsService.ActivateForm(FormTypeCodes.LoginForm);
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			try
			{
				if (AnyErrors()) return;

				lblError.Text = String.Empty;

				UserDTO user = new UserDTO();
				user.UserName = this.userNameTextBox.Text;
				user.PasswordHash = new AuthorizationBusinessService().HashPassword(this.passwordTextBox1.Text);
				user.HasEmptyPassword = false;
				user.FirstName = this.txtBoxFirstName.Text;
				user.LastName = this.txtBoxLastName.Text;
				user.Email = this.txtBoxEmail.Text;
				user.ContactPhone = this.txtBoxPhone.Text;
				user.OfficeNumber = this.txtBoxOfficeNumber.Text;
				user.Title = this.txtBoxTitle.Text;
				user.IsValid = true;
				user.AuthorizationRole = AuthorizationRoleCodes.Operator;

				MainForm mainForm = (MainForm)_formsService.GetFormByCode(FormTypeCodes.MainForm);
				mainForm.loggedUser = _formsService.UsersService.SaveUserDTO(user);
				_formsService.ActivateForm(FormTypeCodes.MainForm);
				_formsService.ResetFormTextBoxes(this.Controls);
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
				this.lblError.Text = "Došlo je do sistemske greške. Kontaktirajte administratora.";
			}
		}

		private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_formsService.Exit(e);
		}

		#region Validation

		private bool AnyErrors()
		{
			if (String.IsNullOrEmpty(this.userNameTextBox.Text)) return true;
			if (String.IsNullOrEmpty(this.passwordTextBox1.Text)) return true;
			if (this.passwordTextBox1.Text.Length < AuthorizationBusinessService.PASSWORD_CHAR_MIN) return true;
			if (String.IsNullOrEmpty(this.passwordTextBox2.Text)) return true;
			if (!this.passwordTextBox1.Text.Equals(this.passwordTextBox2.Text)) return true;
			if (Regex.Matches(this.txtBoxFirstName.Text, @"[0-9]").Count > 0) return true;
			if (_formsService.UsersService.CheckIfUserExists(this.userNameTextBox.Text)) return true;
			if (Regex.Matches(this.txtBoxLastName.Text, @"[0-9]").Count > 0) return true;
			if (Regex.Matches(this.txtBoxPhone.Text, @"[a-zA-Z]").Count > 0) return true;
			return false;
		}

		private void userNameTextBox_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(this.userNameTextBox.Text))
			{
				errorProvider.SetError(this.userNameTextBox, "Morate uneti korisničko ime.");
				return;
			}

			if (_formsService.UsersService.CheckIfUserExists(this.userNameTextBox.Text))
			{
				errorProvider.SetError(this.userNameTextBox, "Korisničko ime je zauzeto.");
				return;
			}

			errorProvider.Clear();
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

		#endregion Validation

		private void helpToolStripHelpItem_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, helpProvider.HelpNamespace);
		}
	}
}
