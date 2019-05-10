using System;

namespace Transcrypt.Domain.Entities
{
    public class Client
    {
        public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }

        public virtual Guid DealerId { get; set; }

        public virtual int DealerClientId { get; set; }

        public virtual string Inn { get; set; }

        public virtual string DocflowUserId { get; set; }

        public virtual string CodeNo { get; set; }

        public virtual Guid AddressId { get; set; }

        public virtual string ContactName { get; set; }

        public virtual string ContactPhone { get; set; }

        public virtual int State { get; set; }

        public virtual Guid OperatorId { get; set; }

        public virtual int Type { get; set; }

        public virtual bool FlagAutoBilling {get;set;}

        public virtual DateTime RegistrationDate {get;set;}

        public virtual bool NewEmployeesWithAdminPermission {get;set;}

        public virtual string ContactEmail {get;set;}

        public virtual int OpenedDirectionType {get;set;}

        public virtual bool WithDepartments {get;set;}

        public virtual string ContactFirstName {get;set;}

        public virtual string ContactLastName {get;set;}

        public virtual string ContactMiddleName {get;set;}

        public virtual int LegalEntityType {get;set;}
    }
}
