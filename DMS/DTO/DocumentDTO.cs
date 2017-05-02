using System;
using System.Collections.Generic;

namespace DMS.DTO
{
	public class DocumentDTO
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Extension { get; set; }
		public bool IsValid { get; set; }
		public bool IsArchived { get; set; }
		public bool IsLocked { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? LastModifiedAt { get; set; }

		// calulated fields
		public string FullName
		{
			get
			{
				return Title + "." + Extension;
			}
		}

		public IList<KeywordDTO> Keywords { get; set; }
		public IList<DocumentShareDTO> DocumentShares { get; set; }
	}
}