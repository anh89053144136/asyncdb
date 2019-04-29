using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ApprovalPackageMap : ClassMap<ApprovalPackage>
    {
        public ApprovalPackageMap()
        {
            Table("ApprovalPackages");

            Id(x => x.Id).GeneratedBy.Guid();

            References(x => x.InternalPackageDc).Column("Id");
        }
    }
}
