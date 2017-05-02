namespace DMS
{
	partial class DocumentDetailsForm
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
			System.Windows.Forms.Label label7;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label9;
			System.Windows.Forms.Panel panel3;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Panel panel1;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Panel panel2;
			System.Windows.Forms.Label label4;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentDetailsForm));
			this.boxSharedUsers = new System.Windows.Forms.ListBox();
			this.btnRemoveShares = new System.Windows.Forms.Button();
			this.selectShareType = new System.Windows.Forms.ComboBox();
			this.txtBoxUserName = new System.Windows.Forms.TextBox();
			this.btnShare = new System.Windows.Forms.Button();
			this.txtBoxTitle = new System.Windows.Forms.TextBox();
			this.btnRemoveKeywords = new System.Windows.Forms.Button();
			this.boxKeywords = new System.Windows.Forms.ListBox();
			this.btnAddKeyword = new System.Windows.Forms.Button();
			this.txtBoxKeyword = new System.Windows.Forms.TextBox();
			this.btnDocumentDetailsSave = new System.Windows.Forms.Button();
			this.btnSaveWriting = new System.Windows.Forms.Button();
			this.btnCloseWr = new System.Windows.Forms.Button();
			this.btnCloseRd = new System.Windows.Forms.Button();
			this.lblInfo = new System.Windows.Forms.Label();
			this.btnOpenForRead = new System.Windows.Forms.Button();
			this.btnOpenForWrite = new System.Windows.Forms.Button();
			this.panelOpen = new System.Windows.Forms.Panel();
			this.panelCloseWrite = new System.Windows.Forms.Panel();
			this.panelCloseRead = new System.Windows.Forms.Panel();
			this.btnCancelDocumentDetails = new System.Windows.Forms.Button();
			this.panelAddFile = new System.Windows.Forms.Panel();
			this.btnAddFile = new System.Windows.Forms.Button();
			this.lblAddedFileInfo = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.helpProvider = new System.Windows.Forms.HelpProvider();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripHelpItem = new System.Windows.Forms.ToolStripMenuItem();
			label7 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			panel3 = new System.Windows.Forms.Panel();
			label3 = new System.Windows.Forms.Label();
			panel1 = new System.Windows.Forms.Panel();
			label5 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			panel2 = new System.Windows.Forms.Panel();
			label4 = new System.Windows.Forms.Label();
			panel3.SuspendLayout();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			this.panelOpen.SuspendLayout();
			this.panelCloseWrite.SuspendLayout();
			this.panelCloseRead.SuspendLayout();
			this.panelAddFile.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label7.Location = new System.Drawing.Point(3, 5);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(248, 18);
			label7.TabIndex = 26;
			label7.Text = "Otvorili ste dokument za čitanje i pisanje";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label1.Location = new System.Drawing.Point(3, 5);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(197, 18);
			label1.TabIndex = 29;
			label1.Text = "Otvorili ste dokument za čitanje";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label9.Location = new System.Drawing.Point(3, 1);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(261, 18);
			label9.TabIndex = 38;
			label9.Text = "Deljenje dokumenta sa drugim korisnicima";
			// 
			// panel3
			// 
			panel3.BackColor = System.Drawing.SystemColors.ControlLight;
			panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel3.Controls.Add(this.boxSharedUsers);
			panel3.Controls.Add(this.btnRemoveShares);
			panel3.Controls.Add(this.selectShareType);
			panel3.Controls.Add(this.txtBoxUserName);
			panel3.Controls.Add(label3);
			panel3.Controls.Add(this.btnShare);
			panel3.Controls.Add(label9);
			panel3.Location = new System.Drawing.Point(326, 73);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(423, 210);
			panel3.TabIndex = 25;
			// 
			// boxSharedUsers
			// 
			this.boxSharedUsers.FormattingEnabled = true;
			this.helpProvider.SetHelpString(this.boxSharedUsers, "Administratori sistema i vlasnik dokumenta već imaju pristup i nisi prikazani u l" +
        "isti.");
			this.boxSharedUsers.Location = new System.Drawing.Point(6, 65);
			this.boxSharedUsers.Name = "boxSharedUsers";
			this.boxSharedUsers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.helpProvider.SetShowHelp(this.boxSharedUsers, true);
			this.boxSharedUsers.Size = new System.Drawing.Size(301, 134);
			this.boxSharedUsers.TabIndex = 46;
			this.toolTip.SetToolTip(this.boxSharedUsers, "Administratori sistema i vlasnik dokumenta već imaju pristup i nisi prikazani u l" +
        "isti.");
			// 
			// btnRemoveShares
			// 
			this.btnRemoveShares.Location = new System.Drawing.Point(313, 176);
			this.btnRemoveShares.Name = "btnRemoveShares";
			this.btnRemoveShares.Size = new System.Drawing.Size(102, 23);
			this.btnRemoveShares.TabIndex = 47;
			this.btnRemoveShares.Text = "Ukloni korisnika";
			this.btnRemoveShares.UseVisualStyleBackColor = true;
			this.btnRemoveShares.Click += new System.EventHandler(this.btnRemoveShares_Click);
			// 
			// selectShareType
			// 
			this.selectShareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectShareType.FormattingEnabled = true;
			this.selectShareType.Items.AddRange(new object[] {
            "Čitanje",
            "Čitanje i pisanje"});
			this.selectShareType.Location = new System.Drawing.Point(223, 29);
			this.selectShareType.MaxDropDownItems = 2;
			this.selectShareType.Name = "selectShareType";
			this.selectShareType.Size = new System.Drawing.Size(118, 21);
			this.selectShareType.TabIndex = 44;
			// 
			// txtBoxUserName
			// 
			this.txtBoxUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtBoxUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.helpProvider.SetHelpString(this.txtBoxUserName, "Administratori sistema i vlasnik dokumenta već imaju pristup i nisi prikazani u l" +
        "isti.");
			this.txtBoxUserName.Location = new System.Drawing.Point(97, 29);
			this.txtBoxUserName.MaxLength = 100;
			this.txtBoxUserName.Name = "txtBoxUserName";
			this.helpProvider.SetShowHelp(this.txtBoxUserName, true);
			this.txtBoxUserName.Size = new System.Drawing.Size(120, 20);
			this.txtBoxUserName.TabIndex = 43;
			this.toolTip.SetToolTip(this.txtBoxUserName, "Administratori sistema i vlasnik dokumenta već imaju pristup i nisi prikazani u l" +
        "isti.");
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label3.Location = new System.Drawing.Point(3, 30);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(92, 17);
			label3.TabIndex = 39;
			label3.Text = "Korisničko ime:";
			// 
			// btnShare
			// 
			this.btnShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShare.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShare.Location = new System.Drawing.Point(347, 27);
			this.btnShare.Name = "btnShare";
			this.helpProvider.SetShowHelp(this.btnShare, false);
			this.btnShare.Size = new System.Drawing.Size(68, 23);
			this.btnShare.TabIndex = 45;
			this.btnShare.Text = "Podeli";
			this.btnShare.UseVisualStyleBackColor = true;
			this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
			// 
			// panel1
			// 
			panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(this.txtBoxTitle);
			panel1.Location = new System.Drawing.Point(15, 73);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(305, 45);
			panel1.TabIndex = 23;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label5.ForeColor = System.Drawing.SystemColors.ControlText;
			label5.Location = new System.Drawing.Point(278, 14);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(15, 17);
			label5.TabIndex = 2;
			label5.Text = "*";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label2.Location = new System.Drawing.Point(6, 14);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(115, 17);
			label2.TabIndex = 0;
			label2.Text = "Naslov dokumenta:";
			// 
			// txtBoxTitle
			// 
			this.helpProvider.SetHelpString(this.txtBoxTitle, "Naslov dokumenta.");
			this.txtBoxTitle.Location = new System.Drawing.Point(127, 13);
			this.txtBoxTitle.MaxLength = 100;
			this.txtBoxTitle.Name = "txtBoxTitle";
			this.helpProvider.SetShowHelp(this.txtBoxTitle, true);
			this.txtBoxTitle.Size = new System.Drawing.Size(145, 20);
			this.txtBoxTitle.TabIndex = 1;
			this.toolTip.SetToolTip(this.txtBoxTitle, "Naslov dokumenta.");
			this.txtBoxTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxTitle_Validating);
			// 
			// panel2
			// 
			panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel2.CausesValidation = false;
			panel2.Controls.Add(this.btnRemoveKeywords);
			panel2.Controls.Add(this.boxKeywords);
			panel2.Controls.Add(this.btnAddKeyword);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(this.txtBoxKeyword);
			panel2.Location = new System.Drawing.Point(15, 124);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(305, 159);
			panel2.TabIndex = 24;
			// 
			// btnRemoveKeywords
			// 
			this.btnRemoveKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemoveKeywords.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoveKeywords.Location = new System.Drawing.Point(222, 123);
			this.btnRemoveKeywords.Name = "btnRemoveKeywords";
			this.btnRemoveKeywords.Size = new System.Drawing.Size(75, 23);
			this.btnRemoveKeywords.TabIndex = 42;
			this.btnRemoveKeywords.Text = "Ukloni";
			this.btnRemoveKeywords.UseVisualStyleBackColor = true;
			this.btnRemoveKeywords.Click += new System.EventHandler(this.btnRemoveKeywords_Click);
			// 
			// boxKeywords
			// 
			this.boxKeywords.FormattingEnabled = true;
			this.boxKeywords.Location = new System.Drawing.Point(9, 51);
			this.boxKeywords.MultiColumn = true;
			this.boxKeywords.Name = "boxKeywords";
			this.boxKeywords.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.boxKeywords.Size = new System.Drawing.Size(207, 95);
			this.boxKeywords.TabIndex = 41;
			// 
			// btnAddKeyword
			// 
			this.btnAddKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddKeyword.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddKeyword.Location = new System.Drawing.Point(222, 11);
			this.btnAddKeyword.Name = "btnAddKeyword";
			this.btnAddKeyword.Size = new System.Drawing.Size(75, 23);
			this.btnAddKeyword.TabIndex = 37;
			this.btnAddKeyword.Text = "Dodaj";
			this.btnAddKeyword.UseVisualStyleBackColor = true;
			this.btnAddKeyword.Click += new System.EventHandler(this.btnAddKeyword_Click);
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label4.Location = new System.Drawing.Point(6, 14);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(72, 17);
			label4.TabIndex = 0;
			label4.Text = "Ključna reč:";
			// 
			// txtBoxKeyword
			// 
			this.txtBoxKeyword.Location = new System.Drawing.Point(84, 13);
			this.txtBoxKeyword.MaxLength = 100;
			this.txtBoxKeyword.Name = "txtBoxKeyword";
			this.txtBoxKeyword.Size = new System.Drawing.Size(132, 20);
			this.txtBoxKeyword.TabIndex = 1;
			// 
			// btnDocumentDetailsSave
			// 
			this.btnDocumentDetailsSave.Location = new System.Drawing.Point(15, 326);
			this.btnDocumentDetailsSave.Name = "btnDocumentDetailsSave";
			this.btnDocumentDetailsSave.Size = new System.Drawing.Size(102, 23);
			this.btnDocumentDetailsSave.TabIndex = 38;
			this.btnDocumentDetailsSave.Text = "Sačuvaj promene";
			this.btnDocumentDetailsSave.UseVisualStyleBackColor = true;
			this.btnDocumentDetailsSave.Click += new System.EventHandler(this.btnDocumentDetailsSave_Click);
			// 
			// btnSaveWriting
			// 
			this.btnSaveWriting.Location = new System.Drawing.Point(331, 3);
			this.btnSaveWriting.Name = "btnSaveWriting";
			this.btnSaveWriting.Size = new System.Drawing.Size(150, 23);
			this.btnSaveWriting.TabIndex = 27;
			this.btnSaveWriting.Text = "Zatvori i sačuvaj izmene";
			this.btnSaveWriting.UseVisualStyleBackColor = true;
			this.btnSaveWriting.Click += new System.EventHandler(this.btnSaveWriting_Click);
			// 
			// btnCloseWr
			// 
			this.btnCloseWr.Location = new System.Drawing.Point(487, 3);
			this.btnCloseWr.Name = "btnCloseWr";
			this.btnCloseWr.Size = new System.Drawing.Size(156, 23);
			this.btnCloseWr.TabIndex = 28;
			this.btnCloseWr.Text = "Zatvori bez čuvanja";
			this.btnCloseWr.UseVisualStyleBackColor = true;
			this.btnCloseWr.Click += new System.EventHandler(this.btnCloseWr_Click);
			// 
			// btnCloseRd
			// 
			this.btnCloseRd.Location = new System.Drawing.Point(285, 3);
			this.btnCloseRd.Name = "btnCloseRd";
			this.btnCloseRd.Size = new System.Drawing.Size(136, 23);
			this.btnCloseRd.TabIndex = 31;
			this.btnCloseRd.Text = "Zatvori dokument";
			this.btnCloseRd.UseVisualStyleBackColor = true;
			this.btnCloseRd.Click += new System.EventHandler(this.btnCloseRd_Click);
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfo.Location = new System.Drawing.Point(12, 25);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(58, 18);
			this.lblInfo.TabIndex = 32;
			this.lblInfo.Text = "InfoText";
			// 
			// btnOpenForRead
			// 
			this.btnOpenForRead.Location = new System.Drawing.Point(3, 3);
			this.btnOpenForRead.Name = "btnOpenForRead";
			this.btnOpenForRead.Size = new System.Drawing.Size(159, 23);
			this.btnOpenForRead.TabIndex = 33;
			this.btnOpenForRead.Text = "Otvori dokument za čitanje";
			this.btnOpenForRead.UseVisualStyleBackColor = true;
			this.btnOpenForRead.Click += new System.EventHandler(this.btnOpenForRead_Click);
			// 
			// btnOpenForWrite
			// 
			this.btnOpenForWrite.Location = new System.Drawing.Point(168, 3);
			this.btnOpenForWrite.Name = "btnOpenForWrite";
			this.btnOpenForWrite.Size = new System.Drawing.Size(200, 23);
			this.btnOpenForWrite.TabIndex = 34;
			this.btnOpenForWrite.Text = "Otvori dokument za čitanje i pisanje";
			this.btnOpenForWrite.UseVisualStyleBackColor = true;
			this.btnOpenForWrite.Click += new System.EventHandler(this.btnOpenForWrite_Click);
			// 
			// panelOpen
			// 
			this.panelOpen.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panelOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelOpen.Controls.Add(this.btnOpenForRead);
			this.panelOpen.Controls.Add(this.btnOpenForWrite);
			this.panelOpen.Location = new System.Drawing.Point(15, 429);
			this.panelOpen.Name = "panelOpen";
			this.panelOpen.Size = new System.Drawing.Size(734, 31);
			this.panelOpen.TabIndex = 35;
			// 
			// panelCloseWrite
			// 
			this.panelCloseWrite.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panelCloseWrite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCloseWrite.Controls.Add(this.btnSaveWriting);
			this.panelCloseWrite.Controls.Add(this.btnCloseWr);
			this.panelCloseWrite.Controls.Add(label7);
			this.panelCloseWrite.Location = new System.Drawing.Point(15, 355);
			this.panelCloseWrite.Name = "panelCloseWrite";
			this.panelCloseWrite.Size = new System.Drawing.Size(734, 31);
			this.panelCloseWrite.TabIndex = 36;
			// 
			// panelCloseRead
			// 
			this.panelCloseRead.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panelCloseRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCloseRead.Controls.Add(label1);
			this.panelCloseRead.Controls.Add(this.btnCloseRd);
			this.panelCloseRead.Location = new System.Drawing.Point(15, 392);
			this.panelCloseRead.Name = "panelCloseRead";
			this.panelCloseRead.Size = new System.Drawing.Size(734, 31);
			this.panelCloseRead.TabIndex = 37;
			// 
			// btnCancelDocumentDetails
			// 
			this.btnCancelDocumentDetails.Location = new System.Drawing.Point(647, 326);
			this.btnCancelDocumentDetails.Name = "btnCancelDocumentDetails";
			this.btnCancelDocumentDetails.Size = new System.Drawing.Size(102, 23);
			this.btnCancelDocumentDetails.TabIndex = 39;
			this.btnCancelDocumentDetails.Text = "Poništi";
			this.btnCancelDocumentDetails.UseVisualStyleBackColor = true;
			this.btnCancelDocumentDetails.Click += new System.EventHandler(this.btnCancelDocumentDetails_Click);
			// 
			// panelAddFile
			// 
			this.panelAddFile.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panelAddFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelAddFile.Controls.Add(this.btnAddFile);
			this.panelAddFile.Controls.Add(this.lblAddedFileInfo);
			this.panelAddFile.Location = new System.Drawing.Point(15, 289);
			this.panelAddFile.Name = "panelAddFile";
			this.panelAddFile.Size = new System.Drawing.Size(734, 31);
			this.panelAddFile.TabIndex = 40;
			// 
			// btnAddFile
			// 
			this.btnAddFile.Location = new System.Drawing.Point(12, 3);
			this.btnAddFile.Name = "btnAddFile";
			this.btnAddFile.Size = new System.Drawing.Size(75, 23);
			this.btnAddFile.TabIndex = 20;
			this.btnAddFile.Text = "Priloži fajl";
			this.btnAddFile.UseVisualStyleBackColor = true;
			this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
			// 
			// lblAddedFileInfo
			// 
			this.lblAddedFileInfo.AutoSize = true;
			this.lblAddedFileInfo.Location = new System.Drawing.Point(104, 8);
			this.lblAddedFileInfo.Name = "lblAddedFileInfo";
			this.lblAddedFileInfo.Size = new System.Drawing.Size(83, 13);
			this.lblAddedFileInfo.TabIndex = 21;
			this.lblAddedFileInfo.Text = "Nije priložen fajl.";
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(235, 329);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(42, 17);
			this.lblError.TabIndex = 41;
			this.lblError.Text = "label6";
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
			this.mainMenu.Size = new System.Drawing.Size(761, 24);
			this.mainMenu.TabIndex = 42;
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
			// DocumentDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 467);
			this.Controls.Add(this.mainMenu);
			this.Controls.Add(this.lblError);
			this.Controls.Add(panel3);
			this.Controls.Add(this.panelAddFile);
			this.Controls.Add(this.btnCancelDocumentDetails);
			this.Controls.Add(this.btnDocumentDetailsSave);
			this.Controls.Add(this.panelCloseWrite);
			this.Controls.Add(this.panelCloseRead);
			this.Controls.Add(this.panelOpen);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(panel2);
			this.Controls.Add(panel1);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DocumentDetailsForm";
			this.Text = "Detalji dokumenta";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocumentDetailsForm_FormClosing);
			this.VisibleChanged += new System.EventHandler(this.DocumentDetailsForm_VisibleChanged);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			this.panelOpen.ResumeLayout(false);
			this.panelCloseWrite.ResumeLayout(false);
			this.panelCloseWrite.PerformLayout();
			this.panelCloseRead.ResumeLayout(false);
			this.panelCloseRead.PerformLayout();
			this.panelAddFile.ResumeLayout(false);
			this.panelAddFile.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnShare;
		private System.Windows.Forms.TextBox txtBoxKeyword;
		private System.Windows.Forms.TextBox txtBoxTitle;
		private System.Windows.Forms.Button btnAddKeyword;
		private System.Windows.Forms.Button btnSaveWriting;
		private System.Windows.Forms.Button btnCloseWr;
		private System.Windows.Forms.Button btnCloseRd;
		private System.Windows.Forms.Button btnOpenForRead;
		private System.Windows.Forms.Panel panelOpen;
		private System.Windows.Forms.Panel panelCloseWrite;
		private System.Windows.Forms.Panel panelCloseRead;
		private System.Windows.Forms.Button btnDocumentDetailsSave;
		private System.Windows.Forms.Button btnCancelDocumentDetails;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Panel panelAddFile;
		private System.Windows.Forms.Button btnAddFile;
		private System.Windows.Forms.Label lblAddedFileInfo;
		private System.Windows.Forms.TextBox txtBoxUserName;
		private System.Windows.Forms.ListBox boxSharedUsers;
		private System.Windows.Forms.Button btnRemoveShares;
		private System.Windows.Forms.ComboBox selectShareType;
		private System.Windows.Forms.ListBox boxKeywords;
		private System.Windows.Forms.Button btnRemoveKeywords;
		private System.Windows.Forms.Button btnOpenForWrite;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.HelpProvider helpProvider;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripHelpItem;
	}
}