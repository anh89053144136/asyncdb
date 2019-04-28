using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ClientNatMap : ClassMap<ClientNat>
    {
        public ClientNatMap()
        {
            Table("ClientNats");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.LastName);
            Map(x => x.FirstName);
            Map(x => x.MiddleName);
            Map(x => x.Inn);
            Map(x => x.Ogrnip);
            Map(x => x.FullName);
        }
    }
}