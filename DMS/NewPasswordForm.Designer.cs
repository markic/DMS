namespace DMS
{
	partial class NewPasswordForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPasswordForm));
			this.label1 = new System.Windows.Forms.Label();
			this.passwordTextBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.passwordTextBox2 = new System.Windows.Forms.TextBox();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.lblError = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.helpProvider = new System.Windows.Forms.HelpProvider();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripHelpItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans", 9.5F);
			this.label1.Location = new System.Drawing.Point(11, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(472, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Izaberite novu lozinku. Ova lozinka će biti korišćena za prijavljivanje na sistem" +
    ". ";
			// 
			// passwordTextBox1
			// 
			this.helpProvider.SetHelpString(this.passwordTextBox1, "Unesite lozinku sa kojom kasnije možete da se prijavljujete na sistem.");
			this.passwordTextBox1.Location = new System.Drawing.Point(134, 91);
			this.passwordTextBox1.MaxLength = 100;
			this.passwordTextBox1.Name = "passwordTextBox1";
			this.passwordTextBox1.PasswordChar = '*';
			this.helpProvider.SetShowHelp(this.passwordTextBox1, true);
			this.passwordTextBox1.Size = new System.Drawing.Size(272, 20);
			this.passwordTextBox1.TabIndex = 1;
			this.passwordTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox1_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Open Sans", 9F);
			this.label2.Location = new System.Drawing.Point(75, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Lozinka:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ponovljena lozinka:";
			// 
			// passwordTextBox2
			// 
			this.helpProvider.SetHelpString(this.passwordTextBox2, "Unesite ponovo lozinku sa kojom kasnije možete da se prijavljujete na sistem.");
			this.passwordTextBox2.Location = new System.Drawing.Point(134, 129);
			this.passwordTextBox2.MaxLength = 100;
			this.passwordTextBox2.Name = "passwordTextBox2";
			this.passwordTextBox2.PasswordChar = '*';
			this.helpProvider.SetShowHelp(this.passwordTextBox2, true);
			this.passwordTextBox2.Size = new System.Drawing.Size(272, 20);
			this.passwordTextBox2.TabIndex = 3;
			this.passwordTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox2_Validating);
			// 
			// btnConfirm
			// 
			this.btnConfirm.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirm.Location = new System.Drawing.Point(331, 178);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(75, 23);
			this.btnConfirm.TabIndex = 5;
			this.btnConfirm.Text = "Potvrdi";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(128, 215);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 15);
			this.lblError.TabIndex = 7;
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
			this.mainMenu.Size = new System.Drawing.Size(495, 24);
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
			// NewPasswordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 262);
			this.Controls.Add(this.mainMenu);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.passwordTextBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.passwordTextBox1);
			this.Controls.Add(this.label1);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewPasswordForm";
			this.Text = "Nova lozinka";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPasswordForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox passwordTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox passwordTextBox2;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.HelpProvider helpProvider;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripHelpItem;
	}
}