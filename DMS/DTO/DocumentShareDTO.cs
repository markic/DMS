
namespace DMS.DTO
{
	public class DocumentShareDTO
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public int DocumentId { get; set; }
		public DocumentAccessRightCodes AccessRight { get; set; }
	}
}
