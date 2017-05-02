using System;

namespace DMS.DTO
{
	public class DocumentFilterDTO
	{
		public string Title { get; set; }
		public string Keywords { get; set; }
		public string Extension { get; set; }
		public DateTime? DateFrom { get; set; }
		public DateTime? DateTo { get; set; }
		public bool OnlyActive { get; set; }
		public bool OnlyArchived { get; set; }
		public string UserName { get; set; }
		public UserDTO LoggedUser { get; set; }
	}
}
