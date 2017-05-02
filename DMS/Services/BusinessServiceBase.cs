using DMS.DomainModel;
using log4net;

namespace DMS.Services
{
	public class BusinessServiceBase
	{
		public static readonly ILog logger = LogManager.GetLogger(typeof(BusinessServiceBase));

		private DMSDataBaseEntities _context = null;

		protected DMSDataBaseEntities Context
		{
			get
			{
				if (_context == null)
				{
					_context = new DMSDataBaseEntities();
				}
				return _context;
			}
		}

		protected void BeginTransaction()
		{
			_context = new DMSDataBaseEntities();
		}

		protected void EndTransaction()
		{
			_context.Dispose();
		}

		~BusinessServiceBase()
		{
			if (_context != null)
			{
				_context.Dispose();
			}
		}
	}
}
