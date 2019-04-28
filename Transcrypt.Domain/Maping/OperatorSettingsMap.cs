using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class OperatorSettingsMap : ClassMap<OperatorSettings>
    {
        public OperatorSettingsMap()
        {
            Table("OperatorSettings");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.OperatorId);
            Map(x => x.Name);
            Map(x => x.Value);

            References(x => x.Operator).Column("OperatorId");
        }
    }
}
