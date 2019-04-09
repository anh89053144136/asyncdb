using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
	public class PasswordRecoveryToken
	{
		/// <summary>
		/// Уникальный токен
		/// </summary>
		public Guid Id { get; set; }
		
		/// <summary>
		/// Дата создания токена
		/// </summary>
		public DateTime CreationDateTime { get; set; }

		/// <summary>
		/// Дата истечения токена
		/// </summary>
		public DateTime ExpirationDateTime { get; set; }

		/// <summary>
		/// Признак того что токен использовался
		/// </summary>
		public int State { get; set; }
		
		/// <summary>
		/// Идентификатор приложения через которое был запрошен токен
		/// </summary>
		public Guid AppId { get; set; }
		
		/// <summary>
		/// Идентификатор пользователя для которого был запрошен токен
		/// </summary>
		public Guid UserId { get; set; }
	}
}
