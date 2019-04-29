using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class RegionMap : ClassMap<Region>
    {
        public RegionMap()
        {
            Table("Regions");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.Code);
            Map(x => x.Name);
            Map(x => x.ShortName);
        }
    }
}