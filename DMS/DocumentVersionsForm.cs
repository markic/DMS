using DMS.DTO;
using DMS.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DMS
{
	public partial class DocumentVersionsForm : Form
	{
		#region Felds

		protected internal DocumentDTO documentDto = null;
		private FormsControlService _formsService;
		private FilesBusinessService _filesService;
		private int? _loadedDocumentVersionId = null;
		private const int _COMMENT_BOX_SIZE_PX = 83;

		private enum GridActionsControlCodes
		{
			Open = 2,
			SeeComments = 3
		}

		#endregion Fields

		#region Constructors
		
		public DocumentVersionsForm(FormsControlService formService)
		{
			_formsService = formService;
			_filesService = new FilesBusinessService();
			InitializeComponent();
			_formsService.InitalizeFormHelpProvider(helpProvider, this, "verzije");
		}

		#endregion Constructors

		private void btnReturnToMain_Click(object sender, EventArgs e)
		{
			_formsService.ActivateForm(FormTypeCodes.MainForm);
		}

		private void DocumentVersionsForm_VisibleChanged(object sender, EventArgs e)
		{
			try
			{
				if (documentDto == null) return;
				this.lblDocumentInfo.Text = String.Format("Verzije dokumenta {0}:", documentDto.FullName);
				this.commentsPanel.Visible = false;
				_loadedDocumentVersionId = null;
				LoadDocumentVersions();
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
			}
		}

		private void LoadDocumentVersions()
		{
			try
			{
				IEnumerable<DocumentVersionDTO> versions = _formsService.DocumentsService.LoadDocumentVersions(documentDto.Id);
				documentVersionDTOBindingSource.Clear();
				if (versions == null) return;
				foreach (DocumentVersionDTO version in versions)
				{
					documentVersionDTOBindingSource.Add(version);
				}

			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
			}
		}

		private void DocumentVersionsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_formsService.Exit(e);
		}

		private void versionsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.ColumnIndex == (int)GridActionsControlCodes.Open)
				{
					DocumentVersionDTO documentVersion = (DocumentVersionDTO)documentVersionDTOBindingSource[e.RowIndex];

					saveFileDialog.FileName = documentDto.Title;
					saveFileDialog.Filter = String.Format("Dokument (*.{0})|*.{0}", documentDto.Extension);

					DialogResult result = saveFileDialog.ShowDialog();
					if (result == DialogResult.OK)
					{
						_filesService.LoadFileFromServer(documentVersion.FilePath, saveFileDialog.FileName);
					} 

					return;
				}
				if (e.ColumnIndex == (int)GridActionsControlCodes.SeeComments)
				{
					this.commentsPanel.Visible = true;
					DocumentVersionDTO documentVersion = (DocumentVersionDTO)documentVersionDTOBindingSource[e.RowIndex];
					LoadComments(documentVersion.Id);
					return;
				}
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
			}
		}

		private void LoadComments(int versionId)
		{
			this.txtBoxNewComment.Text = String.Empty;
			_loadedDocumentVersionId = versionId;

			List<CommentDTO> list = _formsService.DocumentsService.LoadDocumentComments(versionId);
			panelCommentsPlaceholder.Controls.Clear();
			if (list == null) return;
			for (int i = 0; i < list.Count(); i++)
			{
				GenerateCommentPanel(list[i], i);
			}
		}

		private void btnSaveComment_Click(object sender, EventArgs e)
		{
			try
			{
				if (!_loadedDocumentVersionId.HasValue || String.IsNullOrEmpty(this.txtBoxNewComment.Text)) return;
				CommentDTO commentDto = new CommentDTO();
				MainForm form = (MainForm)_formsService.GetFormByCode(FormTypeCodes.MainForm);
				commentDto.UserId = form.loggedUser.Id;
				commentDto.DocumentVersionId = _loadedDocumentVersionId.Value;
				commentDto.Text = this.txtBoxNewComment.Text;
				_formsService.DocumentsService.SaveNewComment(commentDto);
				this.txtBoxNewComment.Text = String.Empty;
				LoadComments(_loadedDocumentVersionId.Value);
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
			}
		}

		private void GenerateCommentPanel(CommentDTO comment, int index)
		{
			if (comment == null) return;
			
			Panel panel = new Panel();
			Label lblUserName = new Label();
			Label lblCreatedAt = new Label();
			Label lblText = new Label();

			lblUserName.AutoSize = true;
			lblUserName.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lblUserName.Location = new System.Drawing.Point(6, 16);
			lblUserName.Size = new System.Drawing.Size(82, 17);
			lblUserName.Text = comment.UserName;

			lblCreatedAt.AutoSize = true;
			lblCreatedAt.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lblCreatedAt.Location = new System.Drawing.Point(235, 16);
			lblCreatedAt.Size = new System.Drawing.Size(100, 15);
			lblCreatedAt.Text = _formsService.FormatDateTime(comment.CreatedAt);

			lblText.AutoSize = true;
			lblText.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lblText.Location = new System.Drawing.Point(6, 42);
			lblText.Size = new System.Drawing.Size(122, 17);
			lblText.Text = comment.Text;

			panel.Controls.Add(lblUserName);
			panel.Controls.Add(lblCreatedAt);
			panel.Controls.Add(lblText);
			panel.BackColor = commentsPanel.BackColor;
			panel.Location = new Point(3, 3 + (_COMMENT_BOX_SIZE_PX + 3) * index);
			panel.Size = new Size(365, _COMMENT_BOX_SIZE_PX);
			panel.AutoScroll = true;

			this.panelCommentsPlaceholder.Controls.Add(panel);
		}

		#region Scroller

		private void panelCommentsPlaceholder_MouseDown(object sender, MouseEventArgs e)
		{
			if (!panelCommentsPlaceholder.Focused)
				panelCommentsPlaceholder.Focus();
		}

		#endregion Scroller

		private void helpToolStripHelpItem_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, helpProvider.HelpNamespace);
		}
	}
}
