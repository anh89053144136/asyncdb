namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public enum OperatorSettingsName
    {
        /// <summary>
        /// Разрешить вход сотрудникам других операторов
        /// </summary>
        AllowLogonOtherOperatorsEmployees = 25,
        
        /// <summary>
        /// Разрешить вход своим организациям через другие (по отношению к данному оператору) входы
        /// </summary>
        AllowLogonThroughOtherEndpoint = 26
    }
}