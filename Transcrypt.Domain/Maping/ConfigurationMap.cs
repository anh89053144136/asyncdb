using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ConfigurationMap : ClassMap<Configuration>
    {
        public ConfigurationMap()
        {
            Table("Configurations");

            Map(x => x.Name);
            Map(x => x.Value);
        }
    }
}
