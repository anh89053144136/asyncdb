using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap()
        {
            Table("Signatures");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.Name);
            Map(x => x.ShortName);
            Map(x => x.Kpp);
            Map(x => x.AddressId);

            References(x => x.Client).Column("ClientId");
            References(x => x.Parent).Column("ParentId");
        }
    }
}
