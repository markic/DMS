using System;

namespace DMS.DTO
{
	public class CommentDTO
	{
		public int DocumentVersionId { get; set; }
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string Text { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
