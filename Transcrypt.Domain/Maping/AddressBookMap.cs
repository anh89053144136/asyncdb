using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class AddressBookMap : ClassMap<AddressBook>
    {
        public AddressBookMap()
        {
            Table("AddressBooks");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.ContactSender);
            Map(x => x.ContactReceiver);
            Map(x => x.State);
            Map(x => x.Description);
            Map(x => x.IsSystem);
            Map(x => x.IsRoaming);
            Map(x => x.CreateDateTime);
            Map(x => x.UpdateDateTime);
        }
    }
}