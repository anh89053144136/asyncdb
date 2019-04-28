using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ProgramInfoMap : ClassMap<ProgramInfo>
    {
        public ProgramInfoMap()
        {
            Table("Signatures");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.Identity);
            Map(x => x.Name);
            Map(x => x.OperatorId);
            Map(x => x.Type);
        }
    }
}
