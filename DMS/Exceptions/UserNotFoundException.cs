using System;

namespace DMS.Exceptions
{
	public class UserNotFoundException : Exception
	{
		public UserNotFoundException()
			: base("Nije pronađen korisnik sa korisničkim imenom:")
		{

		}
	}
}
