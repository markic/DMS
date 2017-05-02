namespace DMS
{
	partial class RegisterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
			this.label1 = new System.Windows.Forms.Label();
			this.userNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.passwordTextBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.passwordTextBox1 = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtBoxOfficeNumber = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtBoxPhone = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtBoxEmail = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBoxTitle = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBoxLastName = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtBoxFirstName = new System.Windows.Forms.TextBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblError = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.helpProvider = new System.Windows.Forms.HelpProvider();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripHelpItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Korisničko ime:";
			// 
			// userNameTextBox
			// 
			this.helpProvider.SetHelpString(this.userNameTextBox, "Unesite jedinstveno korisničko ime sa kojim kasnije možete da se prijavljujete na" +
        " sistem.");
			this.userNameTextBox.Location = new System.Drawing.Point(146, 13);
			this.userNameTextBox.MaxLength = 100;
			this.userNameTextBox.Name = "userNameTextBox";
			this.helpProvider.SetShowHelp(this.userNameTextBox, true);
			this.userNameTextBox.Size = new System.Drawing.Size(214, 20);
			this.userNameTextBox.TabIndex = 1;
			this.userNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.userNameTextBox_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 39);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(272, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Unesite ispavne podatke kako bi se registrovali.";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.userNameTextBox);
			this.panel1.Location = new System.Drawing.Point(12, 66);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(387, 45);
			this.panel1.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(366, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(15, 17);
			this.label5.TabIndex = 2;
			this.label5.Text = "*";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.passwordTextBox2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.passwordTextBox1);
			this.panel2.Location = new System.Drawing.Point(12, 117);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(387, 79);
			this.panel2.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(366, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(15, 17);
			this.label7.TabIndex = 4;
			this.label7.Text = "*";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(366, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(15, 17);
			this.label6.TabIndex = 3;
			this.label6.Text = "*";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Ponovljena lozinka:";
			// 
			// passwordTextBox2
			// 
			this.helpProvider.SetHelpString(this.passwordTextBox2, "Unesite ponovo istu lozinku iz polja iznad.");
			this.passwordTextBox2.Location = new System.Drawing.Point(146, 41);
			this.passwordTextBox2.MaxLength = 100;
			this.passwordTextBox2.Name = "passwordTextBox2";
			this.passwordTextBox2.PasswordChar = '*';
			this.helpProvider.SetShowHelp(this.passwordTextBox2, true);
			this.passwordTextBox2.Size = new System.Drawing.Size(214, 20);
			this.passwordTextBox2.TabIndex = 3;
			this.passwordTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox2_Validating);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(75, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Lozinka:";
			// 
			// passwordTextBox1
			// 
			this.helpProvider.SetHelpString(this.passwordTextBox1, "Unesite lozinku sa kojom kasnije možete da se prijavljujete na sistem.");
			this.passwordTextBox1.Location = new System.Drawing.Point(146, 13);
			this.passwordTextBox1.MaxLength = 100;
			this.passwordTextBox1.Name = "passwordTextBox1";
			this.passwordTextBox1.PasswordChar = '*';
			this.helpProvider.SetShowHelp(this.passwordTextBox1, true);
			this.passwordTextBox1.Size = new System.Drawing.Size(214, 20);
			this.passwordTextBox1.TabIndex = 1;
			this.passwordTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox1_Validating);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.txtBoxOfficeNumber);
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.txtBoxPhone);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.txtBoxEmail);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.txtBoxTitle);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.txtBoxLastName);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.txtBoxFirstName);
			this.panel3.Location = new System.Drawing.Point(12, 202);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(387, 182);
			this.panel3.TabIndex = 5;
			// 
			// txtBoxOfficeNumber
			// 
			this.helpProvider.SetHelpString(this.txtBoxOfficeNumber, "Unesite odgovarajući podatak u polje.");
			this.txtBoxOfficeNumber.Location = new System.Drawing.Point(146, 145);
			this.txtBoxOfficeNumber.MaxLength = 100;
			this.txtBoxOfficeNumber.Name = "txtBoxOfficeNumber";
			this.helpProvider.SetShowHelp(this.txtBoxOfficeNumber, true);
			this.txtBoxOfficeNumber.Size = new System.Drawing.Size(214, 20);
			this.txtBoxOfficeNumber.TabIndex = 11;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(30, 145);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(98, 17);
			this.label13.TabIndex = 10;
			this.label13.Text = "Broj kancelarije:";
			// 
			// txtBoxPhone
			// 
			this.helpProvider.SetHelpString(this.txtBoxPhone, "Unesite odgovarajući podatak u polje.");
			this.txtBoxPhone.Location = new System.Drawing.Point(146, 119);
			this.txtBoxPhone.MaxLength = 100;
			this.txtBoxPhone.Name = "txtBoxPhone";
			this.helpProvider.SetShowHelp(this.txtBoxPhone, true);
			this.txtBoxPhone.Size = new System.Drawing.Size(214, 20);
			this.txtBoxPhone.TabIndex = 9;
			this.txtBoxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxPhone_Validating);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(33, 119);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(95, 17);
			this.label12.TabIndex = 8;
			this.label12.Text = "Kontakt telefon:";
			// 
			// txtBoxEmail
			// 
			this.helpProvider.SetHelpString(this.txtBoxEmail, "Unesite odgovarajući podatak u polje.");
			this.txtBoxEmail.Location = new System.Drawing.Point(146, 93);
			this.txtBoxEmail.MaxLength = 100;
			this.txtBoxEmail.Name = "txtBoxEmail";
			this.helpProvider.SetShowHelp(this.txtBoxEmail, true);
			this.txtBoxEmail.Size = new System.Drawing.Size(214, 20);
			this.txtBoxEmail.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(86, 93);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 17);
			this.label9.TabIndex = 6;
			this.label9.Text = "Email:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(80, 67);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 17);
			this.label8.TabIndex = 4;
			this.label8.Text = "Zvanje:";
			// 
			// txtBoxTitle
			// 
			this.helpProvider.SetHelpString(this.txtBoxTitle, "Unesite odgovarajući podatak u polje.");
			this.txtBoxTitle.Location = new System.Drawing.Point(146, 67);
			this.txtBoxTitle.MaxLength = 100;
			this.txtBoxTitle.Name = "txtBoxTitle";
			this.helpProvider.SetShowHelp(this.txtBoxTitle, true);
			this.txtBoxTitle.Size = new System.Drawing.Size(214, 20);
			this.txtBoxTitle.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(71, 41);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(57, 17);
			this.label10.TabIndex = 2;
			this.label10.Text = "Prezime:";
			// 
			// txtBoxLastName
			// 
			this.helpProvider.SetHelpString(this.txtBoxLastName, "Unesite odgovarajući podatak u polje.");
			this.txtBoxLastName.Location = new System.Drawing.Point(146, 41);
			this.txtBoxLastName.MaxLength = 100;
			this.txtBoxLastName.Name = "txtBoxLastName";
			this.helpProvider.SetShowHelp(this.txtBoxLastName, true);
			this.txtBoxLastName.Size = new System.Drawing.Size(214, 20);
			this.txtBoxLastName.TabIndex = 3;
			this.txtBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxLastName_Validating);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(96, 13);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(32, 17);
			this.label11.TabIndex = 0;
			this.label11.Text = "Ime:";
			// 
			// txtBoxFirstName
			// 
			this.helpProvider.SetHelpString(this.txtBoxFirstName, "Unesite odgovarajući podatak u polje.");
			this.txtBoxFirstName.Location = new System.Drawing.Point(146, 13);
			this.txtBoxFirstName.MaxLength = 100;
			this.txtBoxFirstName.Name = "txtBoxFirstName";
			this.helpProvider.SetShowHelp(this.txtBoxFirstName, true);
			this.txtBoxFirstName.Size = new System.Drawing.Size(214, 20);
			this.txtBoxFirstName.TabIndex = 1;
			this.txtBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxFirstName_Validating);
			// 
			// btnRegister
			// 
			this.btnRegister.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegister.Location = new System.Drawing.Point(304, 414);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(95, 24);
			this.btnRegister.TabIndex = 8;
			this.btnRegister.Text = "Registruj Me";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.CausesValidation = false;
			this.btnLogin.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(12, 414);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(95, 24);
			this.btnLogin.TabIndex = 9;
			this.btnLogin.Text = "Prijava";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Open Sans", 9F);
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(25, 394);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 17);
			this.lblError.TabIndex = 10;
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
			this.mainMenu.Size = new System.Drawing.Size(412, 24);
			this.mainMenu.TabIndex = 11;
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
			this.helpToolStripHelpItem.Size = new System.Drawing.Size(152, 22);
			this.helpToolStripHelpItem.Text = "pomoć";
			this.helpToolStripHelpItem.Click += new System.EventHandler(this.helpToolStripHelpItem_Click);
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 451);
			this.Controls.Add(this.mainMenu);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegisterForm";
			this.Text = "RegisterForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox userNameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox passwordTextBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox passwordTextBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtBoxOfficeNumber;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtBoxPhone;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtBoxEmail;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBoxTitle;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtBoxLastName;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtBoxFirstName;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.HelpProvider helpProvider;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripHelpItem;
	}
}