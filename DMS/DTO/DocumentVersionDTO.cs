using System;

namespace DMS.DTO
{
	public class DocumentVersionDTO
	{
		public int Id { get; set; }
		public int HierarchyId { get; set; }
		public DateTime CreatedAt { get; set; }
		public string FilePath { get; set; }
		public DocumentDTO Document { get; set; }
	}
}
