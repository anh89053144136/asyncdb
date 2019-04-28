using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class Settings20Map : ClassMap<Settings20>
    {
        public Settings20Map()
        {
            Table("Settings20");

            Map(x => x.Name);
            Map(x => x.Value);
        }
    }
}