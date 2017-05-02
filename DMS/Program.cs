using DMS.DataMappers;
using DMS.DomainModel;
using DMS.DTO;
using DMS.Services;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS
{
	static class Program
	{
		/// <summary>
		/// Performs necessary initialization of application
		/// </summary>
		private static void AppStart()
		{
			MappingConfiguration.GenerateMapConfiguration();
			XmlConfigurator.Configure();
			Thread.CurrentThread.CurrentCulture = new CultureInfo("sr-Latn-RS");
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("sr-Latn-RS");
		}
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			try
			{
				AppStart();
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				new FormsControlService().ActivateForm(FormTypeCodes.LoginForm);

				Application.Run();
			}
			catch (Exception ex)
			{
				BusinessServiceBase.logger.Error(ex.Message);
			}

		}
	}
}
