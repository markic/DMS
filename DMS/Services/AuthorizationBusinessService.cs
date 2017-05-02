using System.Text;
using System.Security.Cryptography;
using System.Globalization;

namespace DMS.Services
{
	public class AuthorizationBusinessService : BusinessServiceBase
	{
		private readonly byte [] _md5Key = {15, 12, 34, 86, 32, 13, 32, 1};
		public const int PASSWORD_CHAR_MIN = 7;
		
		public AuthorizationBusinessService()
		{

		}

		public string HashPassword(string clearData)
		{
			UnicodeEncoding encoding = new UnicodeEncoding();
			HashAlgorithm hash = new HMACMD5(_md5Key);

			if (clearData != null)
			{
				byte[] binaryPassword = encoding.GetBytes(clearData);
				byte[] hashValue = hash.ComputeHash(binaryPassword);

				string hashedPassword = "";

				foreach (byte hexdigit in hashValue)
				{
					hashedPassword += hexdigit.ToString("X2", CultureInfo.InvariantCulture.NumberFormat);
				}

				return hashedPassword;
			}

			return null;
		}
	}
}
