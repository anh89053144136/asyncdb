using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class FlcResultMap : ClassMap<FlcResult>
    {
        public FlcResultMap()
        {
            Table("FlcResults");

            Id(x => x.Id);

            Map(x => x.Filename);
            Map(x => x.FileType);
            Map(x => x.Result);
        }
    }
}