using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class SettingMap : ClassMap<Setting>
    {
        public SettingMap()
        {
            Table("Settings");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.Name);
            Map(x => x.Value);
        }
    }
}