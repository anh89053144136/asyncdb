using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            Table("Signatures");

            Id(x => x.Guid).GeneratedBy.Guid();

            Map(x => x.Name);
            Map(x => x.ShortName);
            Map(x => x.Code2);
            Map(x => x.Code3);
        }
    }
}