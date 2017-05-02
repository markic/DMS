namespace DMS
{
	partial class DocumentVersionsForm
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
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label9;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentVersionsForm));
			this.lblDocumentInfo = new System.Windows.Forms.Label();
			this.versionsGrid = new System.Windows.Forms.DataGridView();
			this.Otvori = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Komentari = new System.Windows.Forms.DataGridViewButtonColumn();
			this.commentsPanel = new System.Windows.Forms.Panel();
			this.txtBoxNewComment = new System.Windows.Forms.TextBox();
			this.btnSaveComment = new System.Windows.Forms.Button();
			this.panelCommentsPlaceholder = new System.Windows.Forms.Panel();
			this.btnReturnToMain = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.helpProvider = new System.Windows.Forms.HelpProvider();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripHelpItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hierarchyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.documentVersionDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
			label3 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.versionsGrid)).BeginInit();
			this.commentsPanel.SuspendLayout();
			this.mainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.documentVersionDTOBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label3.Location = new System.Drawing.Point(332, 72);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(0, 20);
			label3.TabIndex = 18;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label9.Location = new System.Drawing.Point(3, 13);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(112, 18);
			label9.TabIndex = 38;
			label9.Text = "Komentari verzije";
			// 
			// lblDocumentInfo
			// 
			this.lblDocumentInfo.AutoSize = true;
			this.lblDocumentInfo.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDocumentInfo.Location = new System.Drawing.Point(12, 27);
			this.lblDocumentInfo.Name = "lblDocumentInfo";
			this.lblDocumentInfo.Size = new System.Drawing.Size(216, 20);
			this.lblDocumentInfo.TabIndex = 16;
			this.lblDocumentInfo.Text = "Verzije dokumenta Naslov.pdf";
			// 
			// versionsGrid
			// 
			this.versionsGrid.AllowUserToAddRows = false;
			this.versionsGrid.AllowUserToDeleteRows = false;
			this.versionsGrid.AllowUserToOrderColumns = true;
			this.versionsGrid.AutoGenerateColumns = false;
			this.versionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.versionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hierarchyIdDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.Otvori,
            this.Komentari});
			this.versionsGrid.DataSource = this.documentVersionDTOBindingSource;
			this.versionsGrid.Location = new System.Drawing.Point(12, 60);
			this.versionsGrid.Name = "versionsGrid";
			this.versionsGrid.ReadOnly = true;
			this.versionsGrid.Size = new System.Drawing.Size(443, 316);
			this.versionsGrid.TabIndex = 20;
			this.versionsGrid.TabStop = false;
			this.versionsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.versionsGrid_CellContentClick);
			// 
			// Otvori
			// 
			this.Otvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Otvori.HeaderText = "Akcija";
			this.Otvori.Name = "Otvori";
			this.Otvori.ReadOnly = true;
			this.Otvori.Text = "Otvori verziju";
			this.Otvori.UseColumnTextForButtonValue = true;
			this.Otvori.Width = 125;
			// 
			// Komentari
			// 
			this.Komentari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Komentari.HeaderText = "Akcija";
			this.Komentari.Name = "Komentari";
			this.Komentari.ReadOnly = true;
			this.Komentari.Text = "Pogledaj komentare";
			this.Komentari.UseColumnTextForButtonValue = true;
			this.Komentari.Width = 125;
			// 
			// commentsPanel
			// 
			this.commentsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.commentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.commentsPanel.Controls.Add(this.txtBoxNewComment);
			this.commentsPanel.Controls.Add(this.btnSaveComment);
			this.commentsPanel.Controls.Add(this.panelCommentsPlaceholder);
			this.commentsPanel.Controls.Add(label9);
			this.commentsPanel.Location = new System.Drawing.Point(463, 60);
			this.commentsPanel.Name = "commentsPanel";
			this.commentsPanel.Size = new System.Drawing.Size(409, 318);
			this.commentsPanel.TabIndex = 26;
			// 
			// txtBoxNewComment
			// 
			this.txtBoxNewComment.Location = new System.Drawing.Point(6, 42);
			this.txtBoxNewComment.MaxLength = 400;
			this.txtBoxNewComment.Multiline = true;
			this.txtBoxNewComment.Name = "txtBoxNewComment";
			this.txtBoxNewComment.Size = new System.Drawing.Size(307, 44);
			this.txtBoxNewComment.TabIndex = 1;
			// 
			// btnSaveComment
			// 
			this.helpProvider.SetHelpString(this.btnSaveComment, "Postavlja uneti komentar na trenutno otvorenu verziju dokumenta.");
			this.btnSaveComment.Location = new System.Drawing.Point(319, 63);
			this.btnSaveComment.Name = "btnSaveComment";
			this.helpProvider.SetShowHelp(this.btnSaveComment, true);
			this.btnSaveComment.Size = new System.Drawing.Size(76, 23);
			this.btnSaveComment.TabIndex = 2;
			this.btnSaveComment.Text = "Postavi";
			this.toolTip.SetToolTip(this.btnSaveComment, "Postavlja uneti komentar na trenutno otvorenu verziju dokumenta.");
			this.btnSaveComment.UseVisualStyleBackColor = true;
			this.btnSaveComment.Click += new System.EventHandler(this.btnSaveComment_Click);
			// 
			// panelCommentsPlaceholder
			// 
			this.panelCommentsPlaceholder.AutoScroll = true;
			this.panelCommentsPlaceholder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panelCommentsPlaceholder.CausesValidation = false;
			this.panelCommentsPlaceholder.Location = new System.Drawing.Point(6, 92);
			this.panelCommentsPlaceholder.Name = "panelCommentsPlaceholder";
			this.panelCommentsPlaceholder.Size = new System.Drawing.Size(389, 221);
			this.panelCommentsPlaceholder.TabIndex = 0;
			this.panelCommentsPlaceholder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCommentsPlaceholder_MouseDown);
			// 
			// btnReturnToMain
			// 
			this.btnReturnToMain.Location = new System.Drawing.Point(12, 382);
			this.btnReturnToMain.Name = "btnReturnToMain";
			this.btnReturnToMain.Size = new System.Drawing.Size(102, 23);
			this.btnReturnToMain.TabIndex = 4;
			this.btnReturnToMain.Text = "Lista dokumenata";
			this.btnReturnToMain.UseVisualStyleBackColor = true;
			this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(884, 24);
			this.mainMenu.TabIndex = 27;
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
			this.helpToolStripHelpItem.Click += new System.EventHandler(this.helpToolStripHelpItem_Click);
			// 
			// hierarchyIdDataGridViewTextBoxColumn
			// 
			this.hierarchyIdDataGridViewTextBoxColumn.DataPropertyName = "HierarchyId";
			this.hierarchyIdDataGridViewTextBoxColumn.HeaderText = "Broj";
			this.hierarchyIdDataGridViewTextBoxColumn.Name = "hierarchyIdDataGridViewTextBoxColumn";
			this.hierarchyIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.hierarchyIdDataGridViewTextBoxColumn.Width = 40;
			// 
			// createdAtDataGridViewTextBoxColumn
			// 
			this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
			this.createdAtDataGridViewTextBoxColumn.HeaderText = "Vreme čuvanja";
			this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
			this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
			this.createdAtDataGridViewTextBoxColumn.Width = 110;
			// 
			// documentVersionDTOBindingSource
			// 
			this.documentVersionDTOBindingSource.DataSource = typeof(DMS.DTO.DocumentVersionDTO);
			// 
			// DocumentVersionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 416);
			this.Controls.Add(this.mainMenu);
			this.Controls.Add(this.btnReturnToMain);
			this.Controls.Add(this.commentsPanel);
			this.Controls.Add(this.versionsGrid);
			this.Controls.Add(label3);
			this.Controls.Add(this.lblDocumentInfo);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DocumentVersionsForm";
			this.Text = "Verzije dokumenta";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocumentVersionsForm_FormClosing);
			this.VisibleChanged += new System.EventHandler(this.DocumentVersionsForm_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.versionsGrid)).EndInit();
			this.commentsPanel.ResumeLayout(false);
			this.commentsPanel.PerformLayout();
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.documentVersionDTOBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView versionsGrid;
		private System.Windows.Forms.Panel commentsPanel;
		private System.Windows.Forms.Panel panelCommentsPlaceholder;
		private System.Windows.Forms.Button btnReturnToMain;
		private System.Windows.Forms.TextBox txtBoxNewComment;
		private System.Windows.Forms.Button btnSaveComment;
		private System.Windows.Forms.Label lblDocumentInfo;
		private System.Windows.Forms.BindingSource documentVersionDTOBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn hierarchyIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewButtonColumn Otvori;
		private System.Windows.Forms.DataGridViewButtonColumn Komentari;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.HelpProvider helpProvider;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripHelpItem;
	}
}