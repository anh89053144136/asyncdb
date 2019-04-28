using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ForeignAddressesMap : ClassMap<ForeignAddresses>
    {
        public ForeignAddressesMap()
        {
            Table("ForeignAddressess");

            Id(x => x.Guid);

            Map(x => x.Text);
            Map(x => x.CountryId);

            References(x => x.Country).Column("CountryId");
        }
    }
}