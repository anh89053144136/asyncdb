using System;

namespace Transcrypt.Domain.Entities
{
	public class PasswordRecoveryToken
	{
		/// <summary>
		/// Уникальный токен
		/// </summary>
		public virtual Guid Id { get; set; }
		
		/// <summary>
		/// Дата создания токена
		/// </summary>
		public virtual DateTime CreationDateTime { get; set; }

		/// <summary>
		/// Дата истечения токена
		/// </summary>
		public virtual DateTime ExpirationDateTime { get; set; }

		/// <summary>
		/// Признак того что токен использовался
		/// </summary>
		public virtual int State { get; set; }
		
		/// <summary>
		/// Идентификатор приложения через которое был запрошен токен
		/// </summary>
		public virtual Guid AppId { get; set; }
		
		/// <summary>
		/// Идентификатор пользователя для которого был запрошен токен
		/// </summary>
		public virtual Guid UserId { get; set; }
	}
}
