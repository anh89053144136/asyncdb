using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ConfigurationMap : ClassMap<Configuration>
    {
        public ConfigurationMap()
        {
            Table("Configurations");

            CompositeId()
              .KeyProperty(x => x.Name)
              .KeyProperty(x => x.Value);
        }
    }
}
