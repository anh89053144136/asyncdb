using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ProgramInfoMap : ClassMap<ProgramInfo>
    {
        public ProgramInfoMap()
        {
            Table("ProgramInfos");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.Identity);
            Map(x => x.Name);
            Map(x => x.OperatorId);
            Map(x => x.Type);
        }
    }
}
