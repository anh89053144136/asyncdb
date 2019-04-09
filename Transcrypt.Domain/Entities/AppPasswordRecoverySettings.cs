using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
	public class AppPasswordRecoverySettings
	{
		public Guid? AppId { get; set; } 
		
		/// <summary>
		/// Адрес хоста 
		/// </summary>
		public string Host { get; set; }

		/// <summary>
		/// Адрес страницы восстановления пароля 
		/// </summary>
		public string RecoveryPage { get; set; }
	}
}
