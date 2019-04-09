using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class Client
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid DealerId { get; set; }

        public int DealerClientId { get; set; }

        public string Inn { get; set; }

        public string DocflowUserId { get; set; }

        public string CodeNo { get; set; }

        public Guid AddressId { get; set; }

        public string ContactName { get; set; }

        public string ContactPhone { get; set; }

        public int State { get; set; }

        public Guid OperatorId { get; set; }

        public int Type { get; set; }

        public bool FlagAutoBilling {get;set;}

        public DateTime RegistrationDate {get;set;}

        public bool NewEmployeesWithAdminPermission {get;set;}

        public string ContactEmail {get;set;}

        public int OpenedDirectionType {get;set;}

        public bool WithDepartments {get;set;}

        public string ContactFirstName {get;set;}

        public string ContactLastName {get;set;}

        public string ContactMiddleName {get;set;}

        public int LegalEntityType {get;set;}
    }
}
