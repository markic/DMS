using System.IO;

namespace DMS.Services
{
	public class FilesBusinessService : BusinessServiceBase
	{
		#region Fields

		private static string _folderPath = Properties.Settings.Default.DocumentsFolderPath;

		#endregion Fields

		#region Methods

		/// <summary>
		/// Saves file to server.
		/// </summary>
		/// <param name="oldFilePath"></param>
		/// <param name="newFilePath"></param>
		public void SaveFileToServer(string oldFilePath, string newFilePath)
		{
			newFilePath = _folderPath + newFilePath;
			File.Copy(oldFilePath, newFilePath);
		}

		/// <summary>
		/// Loads file from server.
		/// </summary>
		/// <param name="version"></param>
		public void LoadFileFromServer(string oldFilePath, string newFilePath)
		{
			oldFilePath = _folderPath + oldFilePath;
			File.Copy(oldFilePath, newFilePath, true);
		}

		#endregion Methods

		public void OpenFileWithDefaultApplication(FileInfo file)
		{
			System.Diagnostics.Process.Start(file.FullName);
		}

	}
}
