namespace DMS
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.welcomeLabel = new System.Windows.Forms.Label();
			this.UserName = new System.Windows.Forms.TextBox();
			this.userNameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblError = new System.Windows.Forms.Label();
			this.btnRegister = new System.Windows.Forms.Button();
			this.lblRegister = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.helpProvider = new System.Windows.Forms.HelpProvider();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripHelpItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// welcomeLabel
			// 
			this.welcomeLabel.AutoSize = true;
			this.welcomeLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.welcomeLabel.Location = new System.Drawing.Point(10, 39);
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.Size = new System.Drawing.Size(385, 22);
			this.welcomeLabel.TabIndex = 0;
			this.welcomeLabel.Text = "Dobrodošli u sistem za upravljanje dokumentima.";
			// 
			// UserName
			// 
			this.UserName.AcceptsTab = true;
			this.UserName.BackColor = System.Drawing.Color.White;
			this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.helpProvider.SetHelpString(this.UserName, "Unesite vaše jedinstveno korisničko ime koje ste izabrali prilikom registracije u" +
        " sistem.");
			this.UserName.Location = new System.Drawing.Point(157, 138);
			this.UserName.MaxLength = 100;
			this.UserName.Name = "UserName";
			this.helpProvider.SetShowHelp(this.UserName, true);
			this.UserName.Size = new System.Drawing.Size(200, 23);
			this.UserName.TabIndex = 1;
			this.toolTip.SetToolTip(this.UserName, "Unesite vaše jedinstveno korisničko ime koje ste izabrali prilikom registracije u" +
        " sistem.");
			this.UserName.Validating += new System.ComponentModel.CancelEventHandler(this.UserName_Validating);
			// 
			// userNameLabel
			// 
			this.userNameLabel.AutoSize = true;
			this.userNameLabel.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userNameLabel.Location = new System.Drawing.Point(33, 141);
			this.userNameLabel.Name = "userNameLabel";
			this.userNameLabel.Size = new System.Drawing.Size(92, 17);
			this.userNameLabel.TabIndex = 2;
			this.userNameLabel.Text = "Korisničko Ime:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLabel.Location = new System.Drawing.Point(72, 178);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(53, 17);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "Lozinka:";
			// 
			// Password
			// 
			this.Password.AcceptsTab = true;
			this.Password.BackColor = System.Drawing.Color.White;
			this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.helpProvider.SetHelpString(this.Password, "Unesite lozinku koju ste izabrali prlikom registracije. Ako se prijavljujete prvi" +
        " put unesite praznu lozinku.");
			this.Password.Location = new System.Drawing.Point(157, 175);
			this.Password.MaxLength = 100;
			this.Password.Name = "Password";
			this.Password.PasswordChar = '*';
			this.helpProvider.SetShowHelp(this.Password, true);
			this.Password.Size = new System.Drawing.Size(200, 23);
			this.Password.TabIndex = 4;
			this.toolTip.SetToolTip(this.Password, "Unesite lozinku koju ste izabrali prlikom registracije. Ako se prijavljujete prvi" +
        " put unesite praznu lozinku.");
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(282, 222);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 24);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Prijavi Me";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Open Sans", 9F);
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(93, 272);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 17);
			this.lblError.TabIndex = 6;
			// 
			// btnRegister
			// 
			this.btnRegister.CausesValidation = false;
			this.btnRegister.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegister.Location = new System.Drawing.Point(263, 326);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(95, 24);
			this.btnRegister.TabIndex = 7;
			this.btnRegister.Text = "Registracija";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// lblRegister
			// 
			this.lblRegister.AutoSize = true;
			this.lblRegister.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRegister.Location = new System.Drawing.Point(165, 330);
			this.lblRegister.Name = "lblRegister";
			this.lblRegister.Size = new System.Drawing.Size(92, 17);
			this.lblRegister.TabIndex = 8;
			this.lblRegister.Text = "Nemate nalog?";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans", 10F);
			this.label1.Location = new System.Drawing.Point(32, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 19);
			this.label1.TabIndex = 9;
			this.label1.Text = "Unesite vaše podatke:";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(407, 24);
			this.mainMenu.TabIndex = 10;
			this.mainMenu.Text = "menuStrip1";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripHelpItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.helpToolStripMenuItem.Text = "&Pomoć";
			// 
			// helpToolStripHelpItem
			// 
			this.helpToolStripHelpItem.Name = "helpToolStripHelpItem";
			this.helpToolStripHelpItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.helpToolStripHelpItem.Size = new System.Drawing.Size(131, 22);
			this.helpToolStripHelpItem.Text = "pomoć";
			this.helpToolStripHelpItem.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(407, 362);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblRegister);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.userNameLabel);
			this.Controls.Add(this.UserName);
			this.Controls.Add(this.welcomeLabel);
			this.Controls.Add(this.mainMenu);
			this.HelpButton = true;
			this.helpProvider.SetHelpKeyword(this, "prijava");
			this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.helpProvider.SetShowHelp(this, true);
			this.Text = "Prijava";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.TextBox UserName;
		private System.Windows.Forms.Label userNameLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Label lblRegister;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.HelpProvider helpProvider;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripHelpItem;
		private System.Windows.Forms.ToolTip toolTip;

		public System.Windows.Forms.TextBox GetUserName { get { return UserName; } }
	}
}

