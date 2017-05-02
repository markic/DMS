using System;

namespace DMS.DTO
{
	public class UserDTO
	{
		public int Id { get; set; }
		
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string UserName { get; set; }
		public bool HasEmptyPassword { get; set; }
		public string PasswordHash { get; set; }
		public string Email { get; set; }
		public string Title { get; set; }
		public string ContactPhone { get; set; }
		public string OfficeNumber { get; set; }
		public DateTime CreatedAt { get; set; }
		public bool IsValid { get; set; }

		public AuthorizationRoleCodes AuthorizationRole { get; set; }

		// calculated fields
		public string DisplayName { get { return FirstName + " " + LastName; } }
	}
}
