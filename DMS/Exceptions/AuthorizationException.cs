using System;

namespace DMS.Exceptions
{
	public class AuthorizationException : Exception
	{
		public AuthorizationException()
			: base("Neautorizovan pristup!")
		{

		}
	}
}
