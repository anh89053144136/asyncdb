using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class RussianAddressesMap : ClassMap<RussianAddresses>
    {
        public RussianAddressesMap()
        {
            Table("Signatures");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.PostIndex);
            Map(x => x.RegionId);
            Map(x => x.Area);
            Map(x => x.City);
            Map(x => x.Settlement);
            Map(x => x.Street);
            Map(x => x.House);
            Map(x => x.Structure);
            Map(x => x.Apartment);

            References(x => x.Region).Column("RegionId");
        }
    }
}
