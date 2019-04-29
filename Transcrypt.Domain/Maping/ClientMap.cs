using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            Table("Clients");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.Name);
            Map(x => x.DealerId);
            Map(x => x.DealerClientId);
            Map(x => x.Inn);
            Map(x => x.DocflowUserId);
            Map(x => x.CodeNo);
            Map(x => x.AddressId);
            Map(x => x.ContactName);
            Map(x => x.ContactPhone);
            Map(x => x.State);
            Map(x => x.OperatorId);
            Map(x => x.Type);
            Map(x => x.FlagAutoBilling);
            Map(x => x.RegistrationDate);
            Map(x => x.NewEmployeesWithAdminPermission);
            Map(x => x.ContactEmail);
            Map(x => x.OpenedDirectionType);
            Map(x => x.WithDepartments);
            Map(x => x.ContactFirstName);
            Map(x => x.ContactLastName);
            Map(x => x.ContactMiddleName);
            Map(x => x.LegalEntityType);
        }
    }
}
