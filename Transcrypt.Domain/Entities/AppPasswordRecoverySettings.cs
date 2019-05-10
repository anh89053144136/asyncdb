using System;

namespace Transcrypt.Domain.Entities
{
	public class AppPasswordRecoverySettings
	{
		public virtual Guid? AppId { get; set; } 
		
		/// <summary>
		/// Адрес хоста 
		/// </summary>
		public virtual string Host { get; set; }

		/// <summary>
		/// Адрес страницы восстановления пароля 
		/// </summary>
		public virtual string RecoveryPage { get; set; }
	}
}
