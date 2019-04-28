namespace Transcrypt.Domain.Entities
{
    /// <summary>
    /// Настройки в базе
    /// </summary>
    public class SettingName
    {
        /// <summary>
        /// Адресс Rabbit'a
        /// </summary>
        public const string RabbitAddress = "rabbit.address";
        /// <summary>
        /// Логин Rabbit'a
        /// </summary>
        public const string RabbitUser = "rabbit.user";
        /// <summary>
        /// Пароль Rabbit'a
        /// </summary>
        public const string RabbitPassword = "rabbit.password";
    }
}