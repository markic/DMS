namespace DMS
{
	partial class MainForm
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
			System.Windows.Forms.Label label6;
			System.Windows.Forms.Label label17;
			System.Windows.Forms.Label label18;
			System.Windows.Forms.Label label19;
			System.Windows.Forms.Label label20;
			System.Windows.Forms.Label label21;
			System.Windows.Forms.Label label16;
			System.Windows.Forms.Label label23;
			System.Windows.Forms.Label label24;
			System.Windows.Forms.Label label22;
			System.Windows.Forms.Label label25;
			System.Windows.Forms.Label label26;
			System.Windows.Forms.Label label28;
			System.Windows.Forms.Label label29;
			System.Windows.Forms.Label label30;
			System.Windows.Forms.Label label31;
			System.Windows.Forms.Label label32;
			System.Windows.Forms.Label label33;
			System.Windows.Forms.Panel panel7;
			System.Windows.Forms.Label label35;
			System.Windows.Forms.Label label34;
			System.Windows.Forms.Panel panel8;
			System.Windows.Forms.Panel panel9;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Panel panel1;
			System.Windows.Forms.Panel panel3;
			System.Windows.Forms.Panel panel4;
			System.Windows.Forms.Panel panel6;
			System.Windows.Forms.Panel panel5;
			System.Windows.Forms.Label label15;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.chkBoxSearchExtensionActive = new System.Windows.Forms.CheckBox();
			this.txtBoxSearchExtension = new System.Windows.Forms.TextBox();
			this.chkBoxSearchKeywordsActive = new System.Windows.Forms.CheckBox();
			this.txtBoxSearchKeywords = new System.Windows.Forms.TextBox();
			this.chkBoxSearchTitleActive = new System.Windows.Forms.CheckBox();
			this.txtBoxSearchTitle = new System.Windows.Forms.TextBox();
			this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
			this.datePickerTo = new System.Windows.Forms.DateTimePicker();
			this.selectDocumentsFilter = new System.Windows.Forms.ComboBox();
			this.panelSearchByUsers = new System.Windows.Forms.Panel();
			this.chkBoxSearchUserNameActive = new System.Windows.Forms.CheckBox();
			this.txtBoxSearchDocumentByUserName = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtBoxPhone = new System.Windows.Forms.TextBox();
			this.txtBoxOfficeNumber = new System.Windows.Forms.TextBox();
			this.txtBoxEmail = new System.Windows.Forms.TextBox();
			this.lblErrorContactInfo = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btnSaveContactInfo = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBoxTitle = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBoxLastName = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtBoxFirstName = new System.Windows.Forms.TextBox();
			this.lblErrorPassword = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.passwordTextBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.passwordTextBox1 = new System.Windows.Forms.TextBox();
			this.btnChangePassword = new System.Windows.Forms.Button();
			this.selectUserRole = new System.Windows.Forms.ComboBox();
			this.tbUserDetailsOfficeNumber = new System.Windows.Forms.TextBox();
			this.tbUserDetailsContactPhone = new System.Windows.Forms.TextBox();
			this.tbUserDetailsEmail = new System.Windows.Forms.TextBox();
			this.tbUserDetailsTitle = new System.Windows.Forms.TextBox();
			this.tbUserDetailsLastName = new System.Windows.Forms.TextBox();
			this.tbUserDetailsFirstName = new System.Windows.Forms.TextBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.documentsTab = new System.Windows.Forms.TabPage();
			this.btnOpenDocumentsHelp = new System.Windows.Forms.Button();
			this.lblError = new System.Windows.Forms.Label();
			this.documentsGrid = new System.Windows.Forms.DataGridView();
			this.btnDocumentDetails = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnDeleteDocument = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnDocumentVersions = new System.Windows.Forms.DataGridViewButtonColumn();
			this.lblDocumentsPaginatorInfo = new System.Windows.Forms.Label();
			this.btnDocumentsNextPage = new System.Windows.Forms.Button();
			this.btnDocumentsPrevPage = new System.Windows.Forms.Button();
			this.btnAddDocument = new System.Windows.Forms.Button();
			this.myDataTab = new System.Windows.Forms.TabPage();
			this.label14 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblAuthorizationRole = new System.Windows.Forms.Label();
			this.usersTab = new System.Windows.Forms.TabPage();
			this.panelUserSearch = new System.Windows.Forms.Panel();
			this.txtBoxSearchUserName = new System.Windows.Forms.TextBox();
			this.txtBoxSearchFirstName = new System.Windows.Forms.TextBox();
			this.btnCancelSearch = new System.Windows.Forms.Button();
			this.btnPerformUserSearch = new System.Windows.Forms.Button();
			this.txtBoxSearchLastName = new System.Windows.Forms.TextBox();
			this.editUserPanel = new System.Windows.Forms.Panel();
			this.lblErrorUserDetails = new System.Windows.Forms.Label();
			this.panelUserName = new System.Windows.Forms.Panel();
			this.tbUserDetailsUserName = new System.Windows.Forms.TextBox();
			this.btnResetPassword = new System.Windows.Forms.Button();
			this.btnCancelUserChanges = new System.Windows.Forms.Button();
			this.btnSaveUserChanges = new System.Windows.Forms.Button();
			this.btnAddNewUser = new System.Windows.Forms.Button();
			this.usersGrid = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EditUser = new System.Windows.Forms.DataGridViewButtonColumn();
			this.DeleteUser = new System.Windows.Forms.DataGridViewButtonColumn();
			this.lblUsername = new System.Windows.Forms.Label();
			this.btnLogout = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.helpProvider = new System.Windows.Forms.HelpProvider();
			this.btnOpenMyDataHelp = new System.Windows.Forms.Button();
			this.btnUsersOpenHelp = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isArchivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.documentDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
			label6 = new System.Windows.Forms.Label();
			label17 = new System.Windows.Forms.Label();
			label18 = new System.Windows.Forms.Label();
			label19 = new System.Windows.Forms.Label();
			label20 = new System.Windows.Forms.Label();
			label21 = new System.Windows.Forms.Label();
			label16 = new System.Windows.Forms.Label();
			label23 = new System.Windows.Forms.Label();
			label24 = new System.Windows.Forms.Label();
			label22 = new System.Windows.Forms.Label();
			label25 = new System.Windows.Forms.Label();
			label26 = new System.Windows.Forms.Label();
			label28 = new System.Windows.Forms.Label();
			label29 = new System.Windows.Forms.Label();
			label30 = new System.Windows.Forms.Label();
			label31 = new System.Windows.Forms.Label();
			label32 = new System.Windows.Forms.Label();
			label33 = new System.Windows.Forms.Label();
			panel7 = new System.Windows.Forms.Panel();
			label35 = new System.Windows.Forms.Label();
			label34 = new System.Windows.Forms.Label();
			panel8 = new System.Windows.Forms.Panel();
			panel9 = new System.Windows.Forms.Panel();
			label2 = new System.Windows.Forms.Label();
			panel1 = new System.Windows.Forms.Panel();
			panel3 = new System.Windows.Forms.Panel();
			panel4 = new System.Windows.Forms.Panel();
			panel6 = new System.Windows.Forms.Panel();
			panel5 = new System.Windows.Forms.Panel();
			label15 = new System.Windows.Forms.Label();
			panel7.SuspendLayout();
			panel8.SuspendLayout();
			panel9.SuspendLayout();
			panel1.SuspendLayout();
			this.panelSearchByUsers.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			panel6.SuspendLayout();
			panel5.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.documentsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.documentsGrid)).BeginInit();
			this.myDataTab.SuspendLayout();
			this.usersTab.SuspendLayout();
			this.panelUserSearch.SuspendLayout();
			this.editUserPanel.SuspendLayout();
			this.panelUserName.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.documentDTOBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Open Sans", 9F);
			label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label6.Location = new System.Drawing.Point(30, 145);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(98, 17);
			label6.TabIndex = 10;
			label6.Text = "Broj kancelarije:";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Font = new System.Drawing.Font("Open Sans", 9F);
			label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label17.Location = new System.Drawing.Point(33, 119);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(95, 17);
			label17.TabIndex = 8;
			label17.Text = "Kontakt telefon:";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Font = new System.Drawing.Font("Open Sans", 9F);
			label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label18.Location = new System.Drawing.Point(86, 93);
			label18.Name = "label18";
			label18.Size = new System.Drawing.Size(42, 17);
			label18.TabIndex = 6;
			label18.Text = "Email:";
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Font = new System.Drawing.Font("Open Sans", 9F);
			label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label19.Location = new System.Drawing.Point(80, 67);
			label19.Name = "label19";
			label19.Size = new System.Drawing.Size(48, 17);
			label19.TabIndex = 4;
			label19.Text = "Zvanje:";
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Font = new System.Drawing.Font("Open Sans", 9F);
			label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label20.Location = new System.Drawing.Point(71, 41);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(57, 17);
			label20.TabIndex = 2;
			label20.Text = "Prezime:";
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Font = new System.Drawing.Font("Open Sans", 9F);
			label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label21.Location = new System.Drawing.Point(96, 13);
			label21.Name = "label21";
			label21.Size = new System.Drawing.Size(32, 17);
			label21.TabIndex = 0;
			label21.Text = "Ime:";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Font = new System.Drawing.Font("Open Sans", 9F);
			label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label16.Location = new System.Drawing.Point(36, 14);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(92, 17);
			label16.TabIndex = 0;
			label16.Text = "Korisničko ime:";
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.Font = new System.Drawing.Font("Open Sans", 9F);
			label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label23.Location = new System.Drawing.Point(5, 14);
			label23.Name = "label23";
			label23.Size = new System.Drawing.Size(135, 17);
			label23.TabIndex = 0;
			label23.Text = "Tip korisničkog naloga:";
			// 
			// label24
			// 
			label24.AutoSize = true;
			label24.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
			label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label24.Location = new System.Drawing.Point(3, 11);
			label24.Name = "label24";
			label24.Size = new System.Drawing.Size(117, 17);
			label24.TabIndex = 0;
			label24.Text = "Pretraga korisnika";
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Font = new System.Drawing.Font("Open Sans", 9F);
			label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label22.Location = new System.Drawing.Point(152, 11);
			label22.Name = "label22";
			label22.Size = new System.Drawing.Size(92, 17);
			label22.TabIndex = 2;
			label22.Text = "Korisničko ime:";
			// 
			// label25
			// 
			label25.AutoSize = true;
			label25.Font = new System.Drawing.Font("Open Sans", 9F);
			label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label25.Location = new System.Drawing.Point(392, 12);
			label25.Name = "label25";
			label25.Size = new System.Drawing.Size(32, 17);
			label25.TabIndex = 4;
			label25.Text = "Ime:";
			// 
			// label26
			// 
			label26.AutoSize = true;
			label26.Font = new System.Drawing.Font("Open Sans", 9F);
			label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label26.Location = new System.Drawing.Point(572, 11);
			label26.Name = "label26";
			label26.Size = new System.Drawing.Size(57, 17);
			label26.TabIndex = 6;
			label26.Text = "Prezime:";
			// 
			// label28
			// 
			label28.AutoSize = true;
			label28.Font = new System.Drawing.Font("Open Sans", 9F);
			label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label28.Location = new System.Drawing.Point(33, 6);
			label28.Name = "label28";
			label28.Size = new System.Drawing.Size(49, 17);
			label28.TabIndex = 2;
			label28.Text = "Naslov:";
			// 
			// label29
			// 
			label29.AutoSize = true;
			label29.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
			label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label29.Location = new System.Drawing.Point(3, 5);
			label29.Name = "label29";
			label29.Size = new System.Drawing.Size(84, 51);
			label29.TabIndex = 0;
			label29.Text = "Pretraga \r\ndokumenata\r\nu sistemu";
			// 
			// label30
			// 
			label30.AutoSize = true;
			label30.Font = new System.Drawing.Font("Open Sans", 9.5F);
			label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label30.Location = new System.Drawing.Point(12, 6);
			label30.Name = "label30";
			label30.Size = new System.Drawing.Size(177, 18);
			label30.TabIndex = 15;
			label30.Text = "Opseg kreiranja dokumenta:";
			// 
			// label31
			// 
			label31.AutoSize = true;
			label31.Font = new System.Drawing.Font("Open Sans", 9F);
			label31.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label31.Location = new System.Drawing.Point(12, 36);
			label31.Name = "label31";
			label31.Size = new System.Drawing.Size(25, 17);
			label31.TabIndex = 16;
			label31.Text = "od:";
			// 
			// label32
			// 
			label32.AutoSize = true;
			label32.Font = new System.Drawing.Font("Open Sans", 9F);
			label32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label32.Location = new System.Drawing.Point(12, 62);
			label32.Name = "label32";
			label32.Size = new System.Drawing.Size(25, 17);
			label32.TabIndex = 17;
			label32.Text = "do:";
			// 
			// label33
			// 
			label33.AutoSize = true;
			label33.Font = new System.Drawing.Font("Open Sans", 9.5F);
			label33.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label33.Location = new System.Drawing.Point(13, 5);
			label33.Name = "label33";
			label33.Size = new System.Drawing.Size(121, 18);
			label33.TabIndex = 19;
			label33.Text = "Stanje dokumenta:";
			// 
			// panel7
			// 
			panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			panel7.Controls.Add(this.chkBoxSearchExtensionActive);
			panel7.Controls.Add(this.txtBoxSearchExtension);
			panel7.Controls.Add(label35);
			panel7.Controls.Add(this.chkBoxSearchKeywordsActive);
			panel7.Controls.Add(this.txtBoxSearchKeywords);
			panel7.Controls.Add(label34);
			panel7.Controls.Add(this.chkBoxSearchTitleActive);
			panel7.Controls.Add(this.txtBoxSearchTitle);
			panel7.Controls.Add(label28);
			panel7.Location = new System.Drawing.Point(106, 3);
			panel7.Name = "panel7";
			panel7.Size = new System.Drawing.Size(321, 87);
			panel7.TabIndex = 12;
			// 
			// chkBoxSearchExtensionActive
			// 
			this.chkBoxSearchExtensionActive.AutoSize = true;
			this.chkBoxSearchExtensionActive.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.chkBoxSearchExtensionActive, "Primenjuje odgovarajuću pretragu nad dokumentima.");
			this.chkBoxSearchExtensionActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.chkBoxSearchExtensionActive.Location = new System.Drawing.Point(246, 62);
			this.chkBoxSearchExtensionActive.Name = "chkBoxSearchExtensionActive";
			this.chkBoxSearchExtensionActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.helpProvider.SetShowHelp(this.chkBoxSearchExtensionActive, true);
			this.chkBoxSearchExtensionActive.Size = new System.Drawing.Size(66, 19);
			this.chkBoxSearchExtensionActive.TabIndex = 17;
			this.chkBoxSearchExtensionActive.Text = "primeni";
			this.chkBoxSearchExtensionActive.UseVisualStyleBackColor = true;
			this.chkBoxSearchExtensionActive.CheckedChanged += new System.EventHandler(this.chkBoxSearchExtensionActive_CheckedChanged);
			// 
			// txtBoxSearchExtension
			// 
			this.txtBoxSearchExtension.BackColor = System.Drawing.SystemColors.Control;
			this.txtBoxSearchExtension.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.txtBoxSearchExtension, "Unesite ekstenziju traženog fajla bez tačke na početku, na primer pdf, docx.");
			this.txtBoxSearchExtension.Location = new System.Drawing.Point(88, 60);
			this.txtBoxSearchExtension.MaxLength = 100;
			this.txtBoxSearchExtension.Name = "txtBoxSearchExtension";
			this.helpProvider.SetShowHelp(this.txtBoxSearchExtension, true);
			this.txtBoxSearchExtension.Size = new System.Drawing.Size(152, 22);
			this.txtBoxSearchExtension.TabIndex = 16;
			// 
			// label35
			// 
			label35.AutoSize = true;
			label35.Font = new System.Drawing.Font("Open Sans", 9F);
			label35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label35.Location = new System.Drawing.Point(27, 62);
			label35.Name = "label35";
			label35.Size = new System.Drawing.Size(55, 17);
			label35.TabIndex = 17;
			label35.Text = "Tip fajla:";
			// 
			// chkBoxSearchKeywordsActive
			// 
			this.chkBoxSearchKeywordsActive.AutoSize = true;
			this.chkBoxSearchKeywordsActive.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.chkBoxSearchKeywordsActive, "Primenjuje odgovarajuću pretragu nad dokumentima.");
			this.chkBoxSearchKeywordsActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.chkBoxSearchKeywordsActive.Location = new System.Drawing.Point(246, 34);
			this.chkBoxSearchKeywordsActive.Name = "chkBoxSearchKeywordsActive";
			this.chkBoxSearchKeywordsActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.helpProvider.SetShowHelp(this.chkBoxSearchKeywordsActive, true);
			this.chkBoxSearchKeywordsActive.Size = new System.Drawing.Size(66, 19);
			this.chkBoxSearchKeywordsActive.TabIndex = 15;
			this.chkBoxSearchKeywordsActive.Text = "primeni";
			this.chkBoxSearchKeywordsActive.UseVisualStyleBackColor = true;
			this.chkBoxSearchKeywordsActive.CheckedChanged += new System.EventHandler(this.chkBoxSearchKeywordsActive_CheckedChanged);
			// 
			// txtBoxSearchKeywords
			// 
			this.txtBoxSearchKeywords.BackColor = System.Drawing.SystemColors.Control;
			this.txtBoxSearchKeywords.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.txtBoxSearchKeywords, "Unesite ključnu reč ili više ključnih reči odvojenih zarezom ili razmakom, biće p" +
        "rikazani dokumenti koji sadrže barem jednu ključnu reč");
			this.txtBoxSearchKeywords.Location = new System.Drawing.Point(88, 32);
			this.txtBoxSearchKeywords.MaxLength = 100;
			this.txtBoxSearchKeywords.Name = "txtBoxSearchKeywords";
			this.helpProvider.SetShowHelp(this.txtBoxSearchKeywords, true);
			this.txtBoxSearchKeywords.Size = new System.Drawing.Size(152, 22);
			this.txtBoxSearchKeywords.TabIndex = 14;
			// 
			// label34
			// 
			label34.AutoSize = true;
			label34.Font = new System.Drawing.Font("Open Sans", 9F);
			label34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label34.Location = new System.Drawing.Point(7, 34);
			label34.Name = "label34";
			label34.Size = new System.Drawing.Size(75, 17);
			label34.TabIndex = 14;
			label34.Text = "Ključne reči:";
			// 
			// chkBoxSearchTitleActive
			// 
			this.chkBoxSearchTitleActive.AutoSize = true;
			this.chkBoxSearchTitleActive.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.chkBoxSearchTitleActive, "Primenjuje odgovarajuću pretragu nad dokumentima.");
			this.chkBoxSearchTitleActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.chkBoxSearchTitleActive.Location = new System.Drawing.Point(246, 5);
			this.chkBoxSearchTitleActive.Name = "chkBoxSearchTitleActive";
			this.chkBoxSearchTitleActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.helpProvider.SetShowHelp(this.chkBoxSearchTitleActive, true);
			this.chkBoxSearchTitleActive.Size = new System.Drawing.Size(66, 19);
			this.chkBoxSearchTitleActive.TabIndex = 13;
			this.chkBoxSearchTitleActive.Text = "primeni";
			this.chkBoxSearchTitleActive.UseVisualStyleBackColor = true;
			this.chkBoxSearchTitleActive.CheckedChanged += new System.EventHandler(this.chkBoxSearchTitleActive_CheckedChanged);
			// 
			// txtBoxSearchTitle
			// 
			this.txtBoxSearchTitle.BackColor = System.Drawing.SystemColors.Control;
			this.txtBoxSearchTitle.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.txtBoxSearchTitle, "Unesite naslov ili deo naslova, biće prikazani svi dokumenti koji u svom naslovu " +
        "sadrže unetu reč kada se primeni primeni.");
			this.txtBoxSearchTitle.Location = new System.Drawing.Point(88, 4);
			this.txtBoxSearchTitle.MaxLength = 100;
			this.txtBoxSearchTitle.Name = "txtBoxSearchTitle";
			this.helpProvider.SetShowHelp(this.txtBoxSearchTitle, true);
			this.txtBoxSearchTitle.Size = new System.Drawing.Size(152, 22);
			this.txtBoxSearchTitle.TabIndex = 12;
			// 
			// panel8
			// 
			panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			panel8.Controls.Add(label30);
			panel8.Controls.Add(label31);
			panel8.Controls.Add(this.datePickerFrom);
			panel8.Controls.Add(this.datePickerTo);
			panel8.Controls.Add(label32);
			panel8.Location = new System.Drawing.Point(433, 3);
			panel8.Name = "panel8";
			panel8.Size = new System.Drawing.Size(201, 87);
			panel8.TabIndex = 13;
			// 
			// datePickerFrom
			// 
			this.datePickerFrom.AllowDrop = true;
			this.datePickerFrom.CalendarFont = new System.Drawing.Font("Open Sans", 10F);
			this.datePickerFrom.Font = new System.Drawing.Font("Open Sans", 8F);
			this.datePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.helpProvider.SetHelpString(this.datePickerFrom, "Prikazuje samo dokumente koji su dodati u sistem posle izabranog datuma.");
			this.datePickerFrom.Location = new System.Drawing.Point(43, 33);
			this.datePickerFrom.Name = "datePickerFrom";
			this.helpProvider.SetShowHelp(this.datePickerFrom, true);
			this.datePickerFrom.Size = new System.Drawing.Size(146, 22);
			this.datePickerFrom.TabIndex = 18;
			this.toolTip.SetToolTip(this.datePickerFrom, "Prikazuje samo dokumente koji su dodati u sistem posle izabranog datuma.");
			this.datePickerFrom.ValueChanged += new System.EventHandler(this.datePickerFrom_ValueChanged);
			// 
			// datePickerTo
			// 
			this.datePickerTo.CalendarFont = new System.Drawing.Font("Open Sans", 10F);
			this.datePickerTo.Font = new System.Drawing.Font("Open Sans", 8F);
			this.datePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.helpProvider.SetHelpString(this.datePickerTo, "Prikazuje samo dokumente koji su dodati u sistem pre izabranog datuma.");
			this.datePickerTo.Location = new System.Drawing.Point(43, 59);
			this.datePickerTo.Name = "datePickerTo";
			this.helpProvider.SetShowHelp(this.datePickerTo, true);
			this.datePickerTo.Size = new System.Drawing.Size(146, 22);
			this.datePickerTo.TabIndex = 19;
			this.toolTip.SetToolTip(this.datePickerTo, "Prikazuje samo dokumente koji su dodati u sistem pre izabranog datuma.");
			this.datePickerTo.ValueChanged += new System.EventHandler(this.datePickerTo_ValueChanged);
			// 
			// panel9
			// 
			panel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			panel9.Controls.Add(label33);
			panel9.Controls.Add(this.selectDocumentsFilter);
			panel9.Location = new System.Drawing.Point(640, 3);
			panel9.Name = "panel9";
			panel9.Size = new System.Drawing.Size(150, 87);
			panel9.TabIndex = 14;
			// 
			// selectDocumentsFilter
			// 
			this.selectDocumentsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectDocumentsFilter.FormattingEnabled = true;
			this.helpProvider.SetHelpString(this.selectDocumentsFilter, "Prikazuje dokumente koji imaju određeni status. Prikazuje sve ili samo arhivirane" +
        " dokumente ili samo dokumente koji nisu arhivirani.");
			this.selectDocumentsFilter.Items.AddRange(new object[] {
            "",
            "Akivan",
            "Arhiviran"});
			this.selectDocumentsFilter.Location = new System.Drawing.Point(16, 32);
			this.selectDocumentsFilter.MaxDropDownItems = 2;
			this.selectDocumentsFilter.Name = "selectDocumentsFilter";
			this.helpProvider.SetShowHelp(this.selectDocumentsFilter, true);
			this.selectDocumentsFilter.Size = new System.Drawing.Size(118, 26);
			this.selectDocumentsFilter.TabIndex = 20;
			this.selectDocumentsFilter.SelectedIndexChanged += new System.EventHandler(this.selectDocumentsFilter_SelectedIndexChanged);
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Open Sans", 9.75F);
			label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label2.Location = new System.Drawing.Point(6, 6);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(135, 18);
			label2.TabIndex = 19;
			label2.Text = "Dokumenti korisnika:";
			// 
			// panel1
			// 
			panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(this.panelSearchByUsers);
			panel1.Controls.Add(panel9);
			panel1.Controls.Add(panel8);
			panel1.Controls.Add(panel7);
			panel1.Controls.Add(label29);
			panel1.Location = new System.Drawing.Point(6, 6);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(987, 95);
			panel1.TabIndex = 11;
			// 
			// panelSearchByUsers
			// 
			this.panelSearchByUsers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panelSearchByUsers.Controls.Add(this.chkBoxSearchUserNameActive);
			this.panelSearchByUsers.Controls.Add(this.txtBoxSearchDocumentByUserName);
			this.panelSearchByUsers.Controls.Add(label2);
			this.panelSearchByUsers.Location = new System.Drawing.Point(796, 3);
			this.panelSearchByUsers.Name = "panelSearchByUsers";
			this.panelSearchByUsers.Size = new System.Drawing.Size(186, 87);
			this.panelSearchByUsers.TabIndex = 16;
			// 
			// chkBoxSearchUserNameActive
			// 
			this.chkBoxSearchUserNameActive.AutoSize = true;
			this.chkBoxSearchUserNameActive.Font = new System.Drawing.Font("Open Sans", 8F);
			this.chkBoxSearchUserNameActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.chkBoxSearchUserNameActive.Location = new System.Drawing.Point(9, 63);
			this.chkBoxSearchUserNameActive.Name = "chkBoxSearchUserNameActive";
			this.chkBoxSearchUserNameActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkBoxSearchUserNameActive.Size = new System.Drawing.Size(66, 19);
			this.chkBoxSearchUserNameActive.TabIndex = 22;
			this.chkBoxSearchUserNameActive.Text = "primeni";
			this.chkBoxSearchUserNameActive.UseVisualStyleBackColor = true;
			this.chkBoxSearchUserNameActive.CheckedChanged += new System.EventHandler(this.chkBoxSearchUserNameActive_CheckedChanged);
			// 
			// txtBoxSearchDocumentByUserName
			// 
			this.txtBoxSearchDocumentByUserName.AcceptsTab = true;
			this.txtBoxSearchDocumentByUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtBoxSearchDocumentByUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtBoxSearchDocumentByUserName.BackColor = System.Drawing.SystemColors.Control;
			this.txtBoxSearchDocumentByUserName.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.txtBoxSearchDocumentByUserName, "Unesite korisničko ime korisnika. U listi dokumenata biće prikazani svi dokumenti" +
        " kojima izabrani korisnik može da pristupi ako pretraga bude primenjena.");
			this.txtBoxSearchDocumentByUserName.Location = new System.Drawing.Point(9, 32);
			this.txtBoxSearchDocumentByUserName.MaxLength = 100;
			this.txtBoxSearchDocumentByUserName.Name = "txtBoxSearchDocumentByUserName";
			this.helpProvider.SetShowHelp(this.txtBoxSearchDocumentByUserName, true);
			this.txtBoxSearchDocumentByUserName.Size = new System.Drawing.Size(158, 22);
			this.txtBoxSearchDocumentByUserName.TabIndex = 21;
			// 
			// panel3
			// 
			panel3.BackColor = System.Drawing.SystemColors.ControlLight;
			panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel3.Controls.Add(this.label13);
			panel3.Controls.Add(this.txtBoxPhone);
			panel3.Controls.Add(this.txtBoxOfficeNumber);
			panel3.Controls.Add(this.txtBoxEmail);
			panel3.Controls.Add(this.lblErrorContactInfo);
			panel3.Controls.Add(this.label9);
			panel3.Controls.Add(this.btnSaveContactInfo);
			panel3.Controls.Add(this.label12);
			panel3.Controls.Add(this.label8);
			panel3.Controls.Add(this.txtBoxTitle);
			panel3.Controls.Add(this.label10);
			panel3.Controls.Add(this.txtBoxLastName);
			panel3.Controls.Add(this.label11);
			panel3.Controls.Add(this.txtBoxFirstName);
			panel3.Location = new System.Drawing.Point(439, 77);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(501, 271);
			panel3.TabIndex = 13;
			panel3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panel3_PreviewKeyDown);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Open Sans", 9F);
			this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label13.Location = new System.Drawing.Point(30, 173);
			this.label13.Name = "label13";
			this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label13.Size = new System.Drawing.Size(98, 17);
			this.label13.TabIndex = 10;
			this.label13.Text = "Broj kancelarije:";
			// 
			// txtBoxPhone
			// 
			this.txtBoxPhone.Location = new System.Drawing.Point(146, 137);
			this.txtBoxPhone.MaxLength = 100;
			this.txtBoxPhone.Name = "txtBoxPhone";
			this.txtBoxPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBoxPhone.Size = new System.Drawing.Size(320, 26);
			this.txtBoxPhone.TabIndex = 9;
			this.txtBoxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxPhone_Validating);
			// 
			// txtBoxOfficeNumber
			// 
			this.txtBoxOfficeNumber.Location = new System.Drawing.Point(146, 169);
			this.txtBoxOfficeNumber.MaxLength = 100;
			this.txtBoxOfficeNumber.Name = "txtBoxOfficeNumber";
			this.txtBoxOfficeNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBoxOfficeNumber.Size = new System.Drawing.Size(320, 26);
			this.txtBoxOfficeNumber.TabIndex = 11;
			// 
			// txtBoxEmail
			// 
			this.txtBoxEmail.Location = new System.Drawing.Point(146, 105);
			this.txtBoxEmail.MaxLength = 100;
			this.txtBoxEmail.Name = "txtBoxEmail";
			this.txtBoxEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBoxEmail.Size = new System.Drawing.Size(320, 26);
			this.txtBoxEmail.TabIndex = 7;
			// 
			// lblErrorContactInfo
			// 
			this.lblErrorContactInfo.AutoSize = true;
			this.lblErrorContactInfo.Font = new System.Drawing.Font("Open Sans", 9F);
			this.lblErrorContactInfo.ForeColor = System.Drawing.Color.Red;
			this.lblErrorContactInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblErrorContactInfo.Location = new System.Drawing.Point(171, 229);
			this.lblErrorContactInfo.Name = "lblErrorContactInfo";
			this.lblErrorContactInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblErrorContactInfo.Size = new System.Drawing.Size(0, 17);
			this.lblErrorContactInfo.TabIndex = 16;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Open Sans", 9F);
			this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label9.Location = new System.Drawing.Point(86, 109);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label9.Size = new System.Drawing.Size(42, 17);
			this.label9.TabIndex = 6;
			this.label9.Text = "Email:";
			// 
			// btnSaveContactInfo
			// 
			this.btnSaveContactInfo.Font = new System.Drawing.Font("Open Sans", 9F);
			this.btnSaveContactInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnSaveContactInfo.Location = new System.Drawing.Point(33, 225);
			this.btnSaveContactInfo.Name = "btnSaveContactInfo";
			this.btnSaveContactInfo.Size = new System.Drawing.Size(122, 24);
			this.btnSaveContactInfo.TabIndex = 14;
			this.btnSaveContactInfo.Text = "Sačuvaj promene";
			this.btnSaveContactInfo.UseVisualStyleBackColor = true;
			this.btnSaveContactInfo.Click += new System.EventHandler(this.btnSaveContactInfo_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Open Sans", 9F);
			this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label12.Location = new System.Drawing.Point(33, 141);
			this.label12.Name = "label12";
			this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label12.Size = new System.Drawing.Size(95, 17);
			this.label12.TabIndex = 8;
			this.label12.Text = "Kontakt telefon:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Open Sans", 9F);
			this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new System.Drawing.Point(80, 77);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label8.Size = new System.Drawing.Size(48, 17);
			this.label8.TabIndex = 4;
			this.label8.Text = "Zvanje:";
			// 
			// txtBoxTitle
			// 
			this.txtBoxTitle.Location = new System.Drawing.Point(146, 73);
			this.txtBoxTitle.MaxLength = 100;
			this.txtBoxTitle.Name = "txtBoxTitle";
			this.txtBoxTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBoxTitle.Size = new System.Drawing.Size(320, 26);
			this.txtBoxTitle.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Open Sans", 9F);
			this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label10.Location = new System.Drawing.Point(71, 45);
			this.label10.Name = "label10";
			this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label10.Size = new System.Drawing.Size(57, 17);
			this.label10.TabIndex = 2;
			this.label10.Text = "Prezime:";
			// 
			// txtBoxLastName
			// 
			this.txtBoxLastName.Location = new System.Drawing.Point(146, 41);
			this.txtBoxLastName.MaxLength = 100;
			this.txtBoxLastName.Name = "txtBoxLastName";
			this.txtBoxLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBoxLastName.Size = new System.Drawing.Size(320, 26);
			this.txtBoxLastName.TabIndex = 3;
			this.txtBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxLastName_Validating);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Open Sans", 9F);
			this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label11.Location = new System.Drawing.Point(96, 13);
			this.label11.Name = "label11";
			this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label11.Size = new System.Drawing.Size(32, 17);
			this.label11.TabIndex = 0;
			this.label11.Text = "Ime:";
			// 
			// txtBoxFirstName
			// 
			this.txtBoxFirstName.Location = new System.Drawing.Point(146, 9);
			this.txtBoxFirstName.MaxLength = 100;
			this.txtBoxFirstName.Name = "txtBoxFirstName";
			this.txtBoxFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBoxFirstName.Size = new System.Drawing.Size(320, 26);
			this.txtBoxFirstName.TabIndex = 1;
			this.txtBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxFirstName_Validating);
			// 
			// panel4
			// 
			panel4.BackColor = System.Drawing.SystemColors.ControlLight;
			panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel4.Controls.Add(this.lblErrorPassword);
			panel4.Controls.Add(this.label4);
			panel4.Controls.Add(this.passwordTextBox2);
			panel4.Controls.Add(this.label5);
			panel4.Controls.Add(this.passwordTextBox1);
			panel4.Controls.Add(this.btnChangePassword);
			panel4.Location = new System.Drawing.Point(24, 77);
			panel4.Name = "panel4";
			panel4.Size = new System.Drawing.Size(385, 142);
			panel4.TabIndex = 12;
			// 
			// lblErrorPassword
			// 
			this.lblErrorPassword.AutoSize = true;
			this.lblErrorPassword.Font = new System.Drawing.Font("Open Sans", 9F);
			this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
			this.lblErrorPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblErrorPassword.Location = new System.Drawing.Point(163, 106);
			this.lblErrorPassword.Name = "lblErrorPassword";
			this.lblErrorPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblErrorPassword.Size = new System.Drawing.Size(0, 17);
			this.lblErrorPassword.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Open Sans", 9F);
			this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new System.Drawing.Point(14, 48);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(114, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Ponovljena lozinka:";
			// 
			// passwordTextBox2
			// 
			this.passwordTextBox2.Location = new System.Drawing.Point(146, 44);
			this.passwordTextBox2.MaxLength = 100;
			this.passwordTextBox2.Name = "passwordTextBox2";
			this.passwordTextBox2.PasswordChar = '*';
			this.passwordTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.passwordTextBox2.Size = new System.Drawing.Size(214, 26);
			this.passwordTextBox2.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Open Sans", 9F);
			this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new System.Drawing.Point(75, 16);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(53, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Lozinka:";
			// 
			// passwordTextBox1
			// 
			this.passwordTextBox1.Location = new System.Drawing.Point(146, 12);
			this.passwordTextBox1.MaxLength = 100;
			this.passwordTextBox1.Name = "passwordTextBox1";
			this.passwordTextBox1.PasswordChar = '*';
			this.passwordTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.passwordTextBox1.Size = new System.Drawing.Size(214, 26);
			this.passwordTextBox1.TabIndex = 1;
			// 
			// btnChangePassword
			// 
			this.btnChangePassword.Font = new System.Drawing.Font("Open Sans", 9F);
			this.btnChangePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnChangePassword.Location = new System.Drawing.Point(17, 102);
			this.btnChangePassword.Name = "btnChangePassword";
			this.btnChangePassword.Size = new System.Drawing.Size(140, 24);
			this.btnChangePassword.TabIndex = 15;
			this.btnChangePassword.Text = "Promeni lozinku";
			this.btnChangePassword.UseVisualStyleBackColor = true;
			this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
			// 
			// panel6
			// 
			panel6.BackColor = System.Drawing.SystemColors.ControlLight;
			panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel6.Controls.Add(label23);
			panel6.Controls.Add(this.selectUserRole);
			panel6.Location = new System.Drawing.Point(10, 253);
			panel6.Name = "panel6";
			panel6.Size = new System.Drawing.Size(387, 45);
			panel6.TabIndex = 14;
			// 
			// selectUserRole
			// 
			this.selectUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectUserRole.FormattingEnabled = true;
			this.helpProvider.SetHelpString(this.selectUserRole, "Administrator može pristupiti svim dokumentima, može pisati nad njima i može vrši" +
        "ti celokupnu administraciju korisnika.");
			this.selectUserRole.Items.AddRange(new object[] {
            "Operator",
            "Administrator"});
			this.selectUserRole.Location = new System.Drawing.Point(146, 10);
			this.selectUserRole.MaxDropDownItems = 2;
			this.selectUserRole.Name = "selectUserRole";
			this.helpProvider.SetShowHelp(this.selectUserRole, true);
			this.selectUserRole.Size = new System.Drawing.Size(214, 26);
			this.selectUserRole.TabIndex = 13;
			// 
			// panel5
			// 
			panel5.BackColor = System.Drawing.SystemColors.ControlLight;
			panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel5.Controls.Add(this.tbUserDetailsOfficeNumber);
			panel5.Controls.Add(label6);
			panel5.Controls.Add(this.tbUserDetailsContactPhone);
			panel5.Controls.Add(label17);
			panel5.Controls.Add(this.tbUserDetailsEmail);
			panel5.Controls.Add(label18);
			panel5.Controls.Add(label19);
			panel5.Controls.Add(this.tbUserDetailsTitle);
			panel5.Controls.Add(label20);
			panel5.Controls.Add(this.tbUserDetailsLastName);
			panel5.Controls.Add(label21);
			panel5.Controls.Add(this.tbUserDetailsFirstName);
			panel5.Location = new System.Drawing.Point(10, 65);
			panel5.Name = "panel5";
			panel5.Size = new System.Drawing.Size(387, 182);
			panel5.TabIndex = 11;
			// 
			// tbUserDetailsOfficeNumber
			// 
			this.tbUserDetailsOfficeNumber.Location = new System.Drawing.Point(146, 145);
			this.tbUserDetailsOfficeNumber.MaxLength = 100;
			this.tbUserDetailsOfficeNumber.Name = "tbUserDetailsOfficeNumber";
			this.tbUserDetailsOfficeNumber.Size = new System.Drawing.Size(214, 26);
			this.tbUserDetailsOfficeNumber.TabIndex = 11;
			// 
			// tbUserDetailsContactPhone
			// 
			this.tbUserDetailsContactPhone.Location = new System.Drawing.Point(146, 119);
			this.tbUserDetailsContactPhone.MaxLength = 100;
			this.tbUserDetailsContactPhone.Name = "tbUserDetailsContactPhone";
			this.tbUserDetailsContactPhone.Size = new System.Drawing.Size(214, 26);
			this.tbUserDetailsContactPhone.TabIndex = 9;
			this.tbUserDetailsContactPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserDetailsContactPhone_Validating);
			// 
			// tbUserDetailsEmail
			// 
			this.tbUserDetailsEmail.Location = new System.Drawing.Point(146, 93);
			this.tbUserDetailsEmail.MaxLength = 100;
			this.tbUserDetailsEmail.Name = "tbUserDetailsEmail";
			this.tbUserDetailsEmail.Size = new System.Drawing.Size(214, 26);
			this.tbUserDetailsEmail.TabIndex = 7;
			// 
			// tbUserDetailsTitle
			// 
			this.tbUserDetailsTitle.Location = new System.Drawing.Point(146, 67);
			this.tbUserDetailsTitle.MaxLength = 100;
			this.tbUserDetailsTitle.Name = "tbUserDetailsTitle";
			this.tbUserDetailsTitle.Size = new System.Drawing.Size(214, 26);
			this.tbUserDetailsTitle.TabIndex = 5;
			// 
			// tbUserDetailsLastName
			// 
			this.tbUserDetailsLastName.Location = new System.Drawing.Point(146, 41);
			this.tbUserDetailsLastName.MaxLength = 100;
			this.tbUserDetailsLastName.Name = "tbUserDetailsLastName";
			this.tbUserDetailsLastName.Size = new System.Drawing.Size(214, 26);
			this.tbUserDetailsLastName.TabIndex = 3;
			this.tbUserDetailsLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserDetailsLastName_Validating);
			// 
			// tbUserDetailsFirstName
			// 
			this.tbUserDetailsFirstName.Location = new System.Drawing.Point(146, 13);
			this.tbUserDetailsFirstName.MaxLength = 100;
			this.tbUserDetailsFirstName.Name = "tbUserDetailsFirstName";
			this.tbUserDetailsFirstName.Size = new System.Drawing.Size(214, 26);
			this.tbUserDetailsFirstName.TabIndex = 1;
			this.tbUserDetailsFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserDetailsFirstName_Validating);
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Font = new System.Drawing.Font("Open Sans", 9F);
			label15.ForeColor = System.Drawing.SystemColors.ControlText;
			label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			label15.Location = new System.Drawing.Point(365, 14);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(15, 17);
			label15.TabIndex = 2;
			label15.Text = "*";
			// 
			// tabControl
			// 
			this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl.Controls.Add(this.documentsTab);
			this.tabControl.Controls.Add(this.myDataTab);
			this.tabControl.Controls.Add(this.usersTab);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Font = new System.Drawing.Font("Open Sans", 10F);
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl.Name = "tabControl";
			this.tabControl.Padding = new System.Drawing.Point(0, 0);
			this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1007, 562);
			this.tabControl.TabIndex = 0;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// documentsTab
			// 
			this.documentsTab.Controls.Add(this.btnOpenDocumentsHelp);
			this.documentsTab.Controls.Add(this.lblError);
			this.documentsTab.Controls.Add(this.documentsGrid);
			this.documentsTab.Controls.Add(this.lblDocumentsPaginatorInfo);
			this.documentsTab.Controls.Add(this.btnDocumentsNextPage);
			this.documentsTab.Controls.Add(this.btnDocumentsPrevPage);
			this.documentsTab.Controls.Add(this.btnAddDocument);
			this.documentsTab.Controls.Add(panel1);
			this.documentsTab.Font = new System.Drawing.Font("Open Sans", 10F);
			this.documentsTab.Location = new System.Drawing.Point(4, 30);
			this.documentsTab.Name = "documentsTab";
			this.documentsTab.Padding = new System.Windows.Forms.Padding(3);
			this.documentsTab.Size = new System.Drawing.Size(999, 528);
			this.documentsTab.TabIndex = 0;
			this.documentsTab.Text = "Upravljanje dokumentima";
			this.documentsTab.UseVisualStyleBackColor = true;
			this.documentsTab.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.documentsTab_PreviewKeyDown);
			// 
			// btnOpenDocumentsHelp
			// 
			this.btnOpenDocumentsHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenDocumentsHelp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnOpenDocumentsHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOpenDocumentsHelp.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.btnOpenDocumentsHelp, "Prelazi na sledeću stranu prikaza dokumenata.");
			this.btnOpenDocumentsHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnOpenDocumentsHelp.Location = new System.Drawing.Point(915, 497);
			this.btnOpenDocumentsHelp.Name = "btnOpenDocumentsHelp";
			this.helpProvider.SetShowHelp(this.btnOpenDocumentsHelp, true);
			this.btnOpenDocumentsHelp.Size = new System.Drawing.Size(78, 23);
			this.btnOpenDocumentsHelp.TabIndex = 18;
			this.btnOpenDocumentsHelp.Text = "Pomoć - F1";
			this.btnOpenDocumentsHelp.UseVisualStyleBackColor = false;
			this.btnOpenDocumentsHelp.Click += new System.EventHandler(this.btnOpenDocumentsHelp_Click);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Open Sans", 9F);
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblError.Location = new System.Drawing.Point(175, 500);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(46, 17);
			this.lblError.TabIndex = 17;
			this.lblError.Text = "greska";
			// 
			// documentsGrid
			// 
			this.documentsGrid.AllowUserToAddRows = false;
			this.documentsGrid.AllowUserToDeleteRows = false;
			this.documentsGrid.AutoGenerateColumns = false;
			this.documentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.documentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn,
            this.isArchivedDataGridViewCheckBoxColumn,
            this.btnDocumentDetails,
            this.btnDeleteDocument,
            this.btnDocumentVersions});
			this.documentsGrid.DataSource = this.documentDTOBindingSource;
			this.documentsGrid.Location = new System.Drawing.Point(6, 103);
			this.documentsGrid.Name = "documentsGrid";
			this.documentsGrid.Size = new System.Drawing.Size(987, 350);
			this.documentsGrid.TabIndex = 16;
			this.documentsGrid.TabStop = false;
			this.documentsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.documentsGrid_CellContentClick);
			// 
			// btnDocumentDetails
			// 
			this.btnDocumentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDocumentDetails.HeaderText = "Akcija";
			this.btnDocumentDetails.Name = "btnDocumentDetails";
			this.btnDocumentDetails.Text = "Detalji dokumenta";
			this.btnDocumentDetails.UseColumnTextForButtonValue = true;
			this.btnDocumentDetails.Width = 150;
			// 
			// btnDeleteDocument
			// 
			this.btnDeleteDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteDocument.HeaderText = "Akcija";
			this.btnDeleteDocument.Name = "btnDeleteDocument";
			this.btnDeleteDocument.Text = "Obriši dokument";
			this.btnDeleteDocument.UseColumnTextForButtonValue = true;
			this.btnDeleteDocument.Width = 150;
			// 
			// btnDocumentVersions
			// 
			this.btnDocumentVersions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDocumentVersions.HeaderText = "Akcija";
			this.btnDocumentVersions.Name = "btnDocumentVersions";
			this.btnDocumentVersions.Text = "Pregledaj verzije dokumenta";
			this.btnDocumentVersions.UseColumnTextForButtonValue = true;
			this.btnDocumentVersions.Width = 220;
			// 
			// lblDocumentsPaginatorInfo
			// 
			this.lblDocumentsPaginatorInfo.AutoSize = true;
			this.lblDocumentsPaginatorInfo.Font = new System.Drawing.Font("Open Sans", 9F);
			this.lblDocumentsPaginatorInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblDocumentsPaginatorInfo.Location = new System.Drawing.Point(356, 459);
			this.lblDocumentsPaginatorInfo.Name = "lblDocumentsPaginatorInfo";
			this.lblDocumentsPaginatorInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDocumentsPaginatorInfo.Size = new System.Drawing.Size(0, 17);
			this.lblDocumentsPaginatorInfo.TabIndex = 15;
			// 
			// btnDocumentsNextPage
			// 
			this.btnDocumentsNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDocumentsNextPage.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.btnDocumentsNextPage, "Prelazi na sledeću stranu prikaza dokumenata.");
			this.btnDocumentsNextPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnDocumentsNextPage.Location = new System.Drawing.Point(915, 456);
			this.btnDocumentsNextPage.Name = "btnDocumentsNextPage";
			this.helpProvider.SetShowHelp(this.btnDocumentsNextPage, true);
			this.btnDocumentsNextPage.Size = new System.Drawing.Size(78, 23);
			this.btnDocumentsNextPage.TabIndex = 14;
			this.btnDocumentsNextPage.Text = "Sledeća";
			this.btnDocumentsNextPage.UseVisualStyleBackColor = true;
			this.btnDocumentsNextPage.Click += new System.EventHandler(this.btnDocumentsNextPage_Click);
			// 
			// btnDocumentsPrevPage
			// 
			this.btnDocumentsPrevPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDocumentsPrevPage.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.btnDocumentsPrevPage, "Prelazi na prethodnu stranu prikaza dokumenata.");
			this.btnDocumentsPrevPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnDocumentsPrevPage.Location = new System.Drawing.Point(6, 456);
			this.btnDocumentsPrevPage.Name = "btnDocumentsPrevPage";
			this.helpProvider.SetShowHelp(this.btnDocumentsPrevPage, true);
			this.btnDocumentsPrevPage.Size = new System.Drawing.Size(78, 23);
			this.btnDocumentsPrevPage.TabIndex = 13;
			this.btnDocumentsPrevPage.Text = "Prethodna";
			this.btnDocumentsPrevPage.UseVisualStyleBackColor = true;
			this.btnDocumentsPrevPage.Click += new System.EventHandler(this.btnDocumentsPrevPage_Click);
			// 
			// btnAddDocument
			// 
			this.btnAddDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddDocument.Font = new System.Drawing.Font("Open Sans", 8F);
			this.btnAddDocument.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnAddDocument.Location = new System.Drawing.Point(3, 497);
			this.btnAddDocument.Name = "btnAddDocument";
			this.btnAddDocument.Size = new System.Drawing.Size(104, 23);
			this.btnAddDocument.TabIndex = 12;
			this.btnAddDocument.Text = "Dodaj dokument";
			this.btnAddDocument.UseVisualStyleBackColor = true;
			this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
			// 
			// myDataTab
			// 
			this.myDataTab.Controls.Add(this.btnOpenMyDataHelp);
			this.myDataTab.Controls.Add(this.label14);
			this.myDataTab.Controls.Add(this.label7);
			this.myDataTab.Controls.Add(this.lblAuthorizationRole);
			this.myDataTab.Controls.Add(panel3);
			this.myDataTab.Controls.Add(panel4);
			this.myDataTab.Location = new System.Drawing.Point(4, 30);
			this.myDataTab.Name = "myDataTab";
			this.myDataTab.Padding = new System.Windows.Forms.Padding(3);
			this.myDataTab.Size = new System.Drawing.Size(999, 528);
			this.myDataTab.TabIndex = 2;
			this.myDataTab.Text = "Moji Podaci";
			this.myDataTab.UseVisualStyleBackColor = true;
			this.myDataTab.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.myDataTab_PreviewKeyDown);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Open Sans", 9F);
			this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label14.Location = new System.Drawing.Point(436, 49);
			this.label14.Name = "label14";
			this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label14.Size = new System.Drawing.Size(295, 17);
			this.label14.TabIndex = 19;
			this.label14.Text = "U svakom trenutku možete promeniti vaše podatke.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Open Sans", 9F);
			this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label7.Location = new System.Drawing.Point(21, 49);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label7.Size = new System.Drawing.Size(133, 17);
			this.label7.TabIndex = 18;
			this.label7.Text = "Promena vaše lozinke.";
			// 
			// lblAuthorizationRole
			// 
			this.lblAuthorizationRole.AutoSize = true;
			this.lblAuthorizationRole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblAuthorizationRole.Location = new System.Drawing.Point(30, 16);
			this.lblAuthorizationRole.Name = "lblAuthorizationRole";
			this.lblAuthorizationRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblAuthorizationRole.Size = new System.Drawing.Size(0, 19);
			this.lblAuthorizationRole.TabIndex = 17;
			// 
			// usersTab
			// 
			this.usersTab.Controls.Add(this.btnUsersOpenHelp);
			this.usersTab.Controls.Add(this.panelUserSearch);
			this.usersTab.Controls.Add(this.editUserPanel);
			this.usersTab.Controls.Add(this.btnAddNewUser);
			this.usersTab.Controls.Add(this.usersGrid);
			this.usersTab.Location = new System.Drawing.Point(4, 30);
			this.usersTab.Name = "usersTab";
			this.usersTab.Padding = new System.Windows.Forms.Padding(3);
			this.usersTab.Size = new System.Drawing.Size(999, 528);
			this.usersTab.TabIndex = 3;
			this.usersTab.Text = "Upravljanje korisnicima";
			this.usersTab.UseVisualStyleBackColor = true;
			// 
			// panelUserSearch
			// 
			this.panelUserSearch.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panelUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelUserSearch.Controls.Add(this.txtBoxSearchUserName);
			this.panelUserSearch.Controls.Add(this.txtBoxSearchFirstName);
			this.panelUserSearch.Controls.Add(this.btnCancelSearch);
			this.panelUserSearch.Controls.Add(this.btnPerformUserSearch);
			this.panelUserSearch.Controls.Add(label26);
			this.panelUserSearch.Controls.Add(this.txtBoxSearchLastName);
			this.panelUserSearch.Controls.Add(label25);
			this.panelUserSearch.Controls.Add(label22);
			this.panelUserSearch.Controls.Add(label24);
			this.panelUserSearch.Location = new System.Drawing.Point(8, 6);
			this.panelUserSearch.Name = "panelUserSearch";
			this.panelUserSearch.Size = new System.Drawing.Size(983, 40);
			this.panelUserSearch.TabIndex = 10;
			// 
			// txtBoxSearchUserName
			// 
			this.txtBoxSearchUserName.BackColor = System.Drawing.SystemColors.Control;
			this.helpProvider.SetHelpString(this.txtBoxSearchUserName, "Pretražuje korisnike sistema po unetom korisničkom imenu.");
			this.txtBoxSearchUserName.Location = new System.Drawing.Point(250, 8);
			this.txtBoxSearchUserName.MaxLength = 100;
			this.txtBoxSearchUserName.Name = "txtBoxSearchUserName";
			this.helpProvider.SetShowHelp(this.txtBoxSearchUserName, true);
			this.txtBoxSearchUserName.Size = new System.Drawing.Size(136, 26);
			this.txtBoxSearchUserName.TabIndex = 30;
			// 
			// txtBoxSearchFirstName
			// 
			this.txtBoxSearchFirstName.BackColor = System.Drawing.SystemColors.Control;
			this.helpProvider.SetHelpString(this.txtBoxSearchFirstName, "Pretražuje korisnike sistema po unetom imenu korisnika.");
			this.txtBoxSearchFirstName.Location = new System.Drawing.Point(430, 8);
			this.txtBoxSearchFirstName.MaxLength = 100;
			this.txtBoxSearchFirstName.Name = "txtBoxSearchFirstName";
			this.helpProvider.SetShowHelp(this.txtBoxSearchFirstName, true);
			this.txtBoxSearchFirstName.Size = new System.Drawing.Size(136, 26);
			this.txtBoxSearchFirstName.TabIndex = 31;
			// 
			// btnCancelSearch
			// 
			this.btnCancelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelSearch.Font = new System.Drawing.Font("Open Sans", 8F);
			this.btnCancelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnCancelSearch.Location = new System.Drawing.Point(817, 9);
			this.btnCancelSearch.Name = "btnCancelSearch";
			this.btnCancelSearch.Size = new System.Drawing.Size(99, 23);
			this.btnCancelSearch.TabIndex = 10;
			this.btnCancelSearch.Text = "Poništi pretragu";
			this.btnCancelSearch.UseVisualStyleBackColor = true;
			this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
			// 
			// btnPerformUserSearch
			// 
			this.btnPerformUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPerformUserSearch.Font = new System.Drawing.Font("Open Sans", 8F);
			this.btnPerformUserSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnPerformUserSearch.Location = new System.Drawing.Point(922, 9);
			this.btnPerformUserSearch.Name = "btnPerformUserSearch";
			this.btnPerformUserSearch.Size = new System.Drawing.Size(56, 23);
			this.btnPerformUserSearch.TabIndex = 33;
			this.btnPerformUserSearch.Text = "Pretraži";
			this.btnPerformUserSearch.UseVisualStyleBackColor = true;
			this.btnPerformUserSearch.Click += new System.EventHandler(this.btnPerformUserSearch_Click);
			// 
			// txtBoxSearchLastName
			// 
			this.txtBoxSearchLastName.BackColor = System.Drawing.SystemColors.Control;
			this.helpProvider.SetHelpString(this.txtBoxSearchLastName, "Pretražuje korisnike sistema po unetom prezimenu korisnika.");
			this.txtBoxSearchLastName.Location = new System.Drawing.Point(635, 7);
			this.txtBoxSearchLastName.MaxLength = 100;
			this.txtBoxSearchLastName.Name = "txtBoxSearchLastName";
			this.helpProvider.SetShowHelp(this.txtBoxSearchLastName, true);
			this.txtBoxSearchLastName.Size = new System.Drawing.Size(136, 26);
			this.txtBoxSearchLastName.TabIndex = 32;
			// 
			// editUserPanel
			// 
			this.editUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.editUserPanel.Controls.Add(this.lblErrorUserDetails);
			this.editUserPanel.Controls.Add(panel6);
			this.editUserPanel.Controls.Add(panel5);
			this.editUserPanel.Controls.Add(this.panelUserName);
			this.editUserPanel.Controls.Add(this.btnResetPassword);
			this.editUserPanel.Controls.Add(this.btnCancelUserChanges);
			this.editUserPanel.Controls.Add(this.btnSaveUserChanges);
			this.editUserPanel.Location = new System.Drawing.Point(8, 47);
			this.editUserPanel.Name = "editUserPanel";
			this.editUserPanel.Size = new System.Drawing.Size(409, 376);
			this.editUserPanel.TabIndex = 3;
			this.editUserPanel.Visible = false;
			// 
			// lblErrorUserDetails
			// 
			this.lblErrorUserDetails.AutoSize = true;
			this.lblErrorUserDetails.Font = new System.Drawing.Font("Open Sans", 9F);
			this.lblErrorUserDetails.ForeColor = System.Drawing.Color.Red;
			this.lblErrorUserDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblErrorUserDetails.Location = new System.Drawing.Point(16, 341);
			this.lblErrorUserDetails.Name = "lblErrorUserDetails";
			this.lblErrorUserDetails.Size = new System.Drawing.Size(0, 17);
			this.lblErrorUserDetails.TabIndex = 15;
			// 
			// panelUserName
			// 
			this.panelUserName.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panelUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelUserName.Controls.Add(label15);
			this.panelUserName.Controls.Add(label16);
			this.panelUserName.Controls.Add(this.tbUserDetailsUserName);
			this.panelUserName.Location = new System.Drawing.Point(10, 14);
			this.panelUserName.Name = "panelUserName";
			this.panelUserName.Size = new System.Drawing.Size(387, 45);
			this.panelUserName.TabIndex = 9;
			// 
			// tbUserDetailsUserName
			// 
			this.tbUserDetailsUserName.BackColor = System.Drawing.SystemColors.Control;
			this.tbUserDetailsUserName.Location = new System.Drawing.Point(146, 10);
			this.tbUserDetailsUserName.MaxLength = 100;
			this.tbUserDetailsUserName.Name = "tbUserDetailsUserName";
			this.tbUserDetailsUserName.Size = new System.Drawing.Size(214, 26);
			this.tbUserDetailsUserName.TabIndex = 1;
			this.tbUserDetailsUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserDetailsUserName_Validating);
			// 
			// btnResetPassword
			// 
			this.btnResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetPassword.Font = new System.Drawing.Font("Open Sans", 8F);
			this.btnResetPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnResetPassword.Location = new System.Drawing.Point(300, 304);
			this.btnResetPassword.Name = "btnResetPassword";
			this.btnResetPassword.Size = new System.Drawing.Size(97, 23);
			this.btnResetPassword.TabIndex = 6;
			this.btnResetPassword.Text = "Resetuj lozinku";
			this.btnResetPassword.UseVisualStyleBackColor = true;
			this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
			// 
			// btnCancelUserChanges
			// 
			this.btnCancelUserChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelUserChanges.Font = new System.Drawing.Font("Open Sans", 8F);
			this.btnCancelUserChanges.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnCancelUserChanges.Location = new System.Drawing.Point(113, 304);
			this.btnCancelUserChanges.Name = "btnCancelUserChanges";
			this.btnCancelUserChanges.Size = new System.Drawing.Size(53, 23);
			this.btnCancelUserChanges.TabIndex = 5;
			this.btnCancelUserChanges.Text = "Poništi";
			this.btnCancelUserChanges.UseVisualStyleBackColor = true;
			this.btnCancelUserChanges.Click += new System.EventHandler(this.btnCancelUserChanges_Click);
			// 
			// btnSaveUserChanges
			// 
			this.btnSaveUserChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveUserChanges.Font = new System.Drawing.Font("Open Sans", 8F);
			this.btnSaveUserChanges.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnSaveUserChanges.Location = new System.Drawing.Point(10, 304);
			this.btnSaveUserChanges.Name = "btnSaveUserChanges";
			this.btnSaveUserChanges.Size = new System.Drawing.Size(97, 23);
			this.btnSaveUserChanges.TabIndex = 4;
			this.btnSaveUserChanges.Text = "Sačuvaj izmene";
			this.btnSaveUserChanges.UseVisualStyleBackColor = true;
			this.btnSaveUserChanges.Click += new System.EventHandler(this.btnSaveUserChanges_Click);
			// 
			// btnAddNewUser
			// 
			this.btnAddNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddNewUser.Font = new System.Drawing.Font("Open Sans", 8F);
			this.btnAddNewUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnAddNewUser.Location = new System.Drawing.Point(8, 497);
			this.btnAddNewUser.Name = "btnAddNewUser";
			this.btnAddNewUser.Size = new System.Drawing.Size(114, 23);
			this.btnAddNewUser.TabIndex = 2;
			this.btnAddNewUser.Text = "Napravi nov nalog";
			this.btnAddNewUser.UseVisualStyleBackColor = true;
			this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
			// 
			// usersGrid
			// 
			this.usersGrid.AllowUserToAddRows = false;
			this.usersGrid.AllowUserToDeleteRows = false;
			this.usersGrid.AllowUserToOrderColumns = true;
			this.usersGrid.AutoGenerateColumns = false;
			this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.usersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.userNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.EditUser,
            this.DeleteUser});
			this.usersGrid.DataSource = this.userDTOBindingSource;
			this.usersGrid.Location = new System.Drawing.Point(8, 52);
			this.usersGrid.Name = "usersGrid";
			this.usersGrid.ReadOnly = true;
			this.usersGrid.Size = new System.Drawing.Size(983, 439);
			this.usersGrid.TabIndex = 0;
			this.usersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGrid_CellContentClick);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Width = 50;
			// 
			// EditUser
			// 
			this.EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditUser.HeaderText = "Akcija";
			this.EditUser.Name = "EditUser";
			this.EditUser.ReadOnly = true;
			this.EditUser.Text = "Izmeni podatke";
			this.EditUser.UseColumnTextForButtonValue = true;
			this.EditUser.Width = 145;
			// 
			// DeleteUser
			// 
			this.DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteUser.HeaderText = "Akcija";
			this.DeleteUser.Name = "DeleteUser";
			this.DeleteUser.ReadOnly = true;
			this.DeleteUser.Text = "Obriši korisnika";
			this.DeleteUser.UseColumnTextForButtonValue = true;
			this.DeleteUser.Width = 145;
			// 
			// lblUsername
			// 
			this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Open Sans", 9F);
			this.lblUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblUsername.Location = new System.Drawing.Point(859, 3);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(0, 17);
			this.lblUsername.TabIndex = 0;
			// 
			// btnLogout
			// 
			this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogout.Font = new System.Drawing.Font("Open Sans", 8F);
			this.btnLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnLogout.Location = new System.Drawing.Point(947, 0);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(53, 23);
			this.btnLogout.TabIndex = 1;
			this.btnLogout.Text = "Odjava";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// btnOpenMyDataHelp
			// 
			this.btnOpenMyDataHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenMyDataHelp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnOpenMyDataHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOpenMyDataHelp.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.btnOpenMyDataHelp, "Prelazi na sledeću stranu prikaza dokumenata.");
			this.btnOpenMyDataHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnOpenMyDataHelp.Location = new System.Drawing.Point(862, 14);
			this.btnOpenMyDataHelp.Name = "btnOpenMyDataHelp";
			this.helpProvider.SetShowHelp(this.btnOpenMyDataHelp, true);
			this.btnOpenMyDataHelp.Size = new System.Drawing.Size(78, 23);
			this.btnOpenMyDataHelp.TabIndex = 20;
			this.btnOpenMyDataHelp.Text = "Pomoć - F1";
			this.btnOpenMyDataHelp.UseVisualStyleBackColor = false;
			this.btnOpenMyDataHelp.Click += new System.EventHandler(this.btnOpenMyDataHelp_Click);
			this.btnOpenMyDataHelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOpenMyDataHelp_KeyDown);
			this.btnOpenMyDataHelp.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnOpenMyDataHelp_PreviewKeyDown);
			// 
			// btnUsersOpenHelp
			// 
			this.btnUsersOpenHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUsersOpenHelp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnUsersOpenHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUsersOpenHelp.Font = new System.Drawing.Font("Open Sans", 8F);
			this.helpProvider.SetHelpString(this.btnUsersOpenHelp, "Prelazi na sledeću stranu prikaza dokumenata.");
			this.btnUsersOpenHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnUsersOpenHelp.Location = new System.Drawing.Point(913, 497);
			this.btnUsersOpenHelp.Name = "btnUsersOpenHelp";
			this.helpProvider.SetShowHelp(this.btnUsersOpenHelp, true);
			this.btnUsersOpenHelp.Size = new System.Drawing.Size(78, 23);
			this.btnUsersOpenHelp.TabIndex = 21;
			this.btnUsersOpenHelp.Text = "Pomoć - F1";
			this.btnUsersOpenHelp.UseVisualStyleBackColor = false;
			this.btnUsersOpenHelp.Click += new System.EventHandler(this.btnUsersOpenHelp_Click);
			this.btnUsersOpenHelp.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnUsersOpenHelp_PreviewKeyDown);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 44;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Naslov dokumenta";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			this.titleDataGridViewTextBoxColumn.ReadOnly = true;
			this.titleDataGridViewTextBoxColumn.Width = 200;
			// 
			// extensionDataGridViewTextBoxColumn
			// 
			this.extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
			this.extensionDataGridViewTextBoxColumn.HeaderText = "Tip fajla";
			this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
			this.extensionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// isArchivedDataGridViewCheckBoxColumn
			// 
			this.isArchivedDataGridViewCheckBoxColumn.DataPropertyName = "IsArchived";
			this.isArchivedDataGridViewCheckBoxColumn.HeaderText = "Arhiviran";
			this.isArchivedDataGridViewCheckBoxColumn.Name = "isArchivedDataGridViewCheckBoxColumn";
			this.isArchivedDataGridViewCheckBoxColumn.Width = 80;
			// 
			// documentDTOBindingSource
			// 
			this.documentDTOBindingSource.DataSource = typeof(DMS.DTO.DocumentDTO);
			// 
			// userNameDataGridViewTextBoxColumn
			// 
			this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
			this.userNameDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
			this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
			this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.userNameDataGridViewTextBoxColumn.Width = 200;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "Ime";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.firstNameDataGridViewTextBoxColumn.Width = 200;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "Prezime";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.lastNameDataGridViewTextBoxColumn.Width = 200;
			// 
			// userDTOBindingSource
			// 
			this.userDTOBindingSource.DataSource = typeof(DMS.DTO.UserDTO);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1007, 562);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.tabControl);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Sistem za upravljanje dokumentima";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			panel8.ResumeLayout(false);
			panel8.PerformLayout();
			panel9.ResumeLayout(false);
			panel9.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			this.panelSearchByUsers.ResumeLayout(false);
			this.panelSearchByUsers.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.documentsTab.ResumeLayout(false);
			this.documentsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.documentsGrid)).EndInit();
			this.myDataTab.ResumeLayout(false);
			this.myDataTab.PerformLayout();
			this.usersTab.ResumeLayout(false);
			this.panelUserSearch.ResumeLayout(false);
			this.panelUserSearch.PerformLayout();
			this.editUserPanel.ResumeLayout(false);
			this.editUserPanel.PerformLayout();
			this.panelUserName.ResumeLayout(false);
			this.panelUserName.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.documentDTOBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage documentsTab;
		private System.Windows.Forms.TabPage myDataTab;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblErrorContactInfo;
		private System.Windows.Forms.Button btnChangePassword;
		private System.Windows.Forms.Button btnSaveContactInfo;
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox passwordTextBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox passwordTextBox1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblAuthorizationRole;
		private System.Windows.Forms.Label lblErrorPassword;
		private System.Windows.Forms.TabPage usersTab;
		private System.Windows.Forms.DataGridView usersGrid;
		private System.Windows.Forms.BindingSource userDTOBindingSource;
		private System.Windows.Forms.Button btnAddNewUser;
		private System.Windows.Forms.Panel editUserPanel;
		private System.Windows.Forms.Button btnCancelUserChanges;
		private System.Windows.Forms.Button btnSaveUserChanges;
		private System.Windows.Forms.Button btnResetPassword;
		private System.Windows.Forms.Panel panelUserName;
		private System.Windows.Forms.TextBox tbUserDetailsUserName;
		private System.Windows.Forms.TextBox tbUserDetailsOfficeNumber;
		private System.Windows.Forms.TextBox tbUserDetailsContactPhone;
		private System.Windows.Forms.TextBox tbUserDetailsEmail;
		private System.Windows.Forms.TextBox tbUserDetailsTitle;
		private System.Windows.Forms.TextBox tbUserDetailsLastName;
		private System.Windows.Forms.TextBox tbUserDetailsFirstName;
		private System.Windows.Forms.ComboBox selectUserRole;
		private System.Windows.Forms.Label lblErrorUserDetails;
		private System.Windows.Forms.Panel panelUserSearch;
		private System.Windows.Forms.Button btnCancelSearch;
		private System.Windows.Forms.Button btnPerformUserSearch;
		private System.Windows.Forms.TextBox txtBoxSearchLastName;
		private System.Windows.Forms.TextBox txtBoxSearchUserName;
		private System.Windows.Forms.TextBox txtBoxSearchFirstName;
		private System.Windows.Forms.ComboBox selectDocumentsFilter;
		private System.Windows.Forms.DateTimePicker datePickerTo;
		private System.Windows.Forms.DateTimePicker datePickerFrom;
		private System.Windows.Forms.TextBox txtBoxSearchTitle;
		private System.Windows.Forms.CheckBox chkBoxSearchExtensionActive;
		private System.Windows.Forms.TextBox txtBoxSearchExtension;
		private System.Windows.Forms.CheckBox chkBoxSearchKeywordsActive;
		private System.Windows.Forms.TextBox txtBoxSearchKeywords;
		private System.Windows.Forms.CheckBox chkBoxSearchTitleActive;
		private System.Windows.Forms.Label lblDocumentsPaginatorInfo;
		private System.Windows.Forms.Button btnDocumentsNextPage;
		private System.Windows.Forms.Button btnDocumentsPrevPage;
		private System.Windows.Forms.Button btnAddDocument;
		private System.Windows.Forms.Panel panelSearchByUsers;
		private System.Windows.Forms.TextBox txtBoxSearchDocumentByUserName;
		private System.Windows.Forms.DataGridView documentsGrid;
		private System.Windows.Forms.CheckBox chkBoxSearchUserNameActive;
		private System.Windows.Forms.BindingSource documentDTOBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isArchivedDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewButtonColumn btnDocumentDetails;
		private System.Windows.Forms.DataGridViewButtonColumn btnDeleteDocument;
		private System.Windows.Forms.DataGridViewButtonColumn btnDocumentVersions;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewButtonColumn EditUser;
		private System.Windows.Forms.DataGridViewButtonColumn DeleteUser;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.HelpProvider helpProvider;
		private System.Windows.Forms.Button btnOpenDocumentsHelp;
		private System.Windows.Forms.Button btnOpenMyDataHelp;
		private System.Windows.Forms.Button btnUsersOpenHelp;
	}
}