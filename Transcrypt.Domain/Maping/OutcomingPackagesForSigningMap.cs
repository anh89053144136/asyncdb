using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class OutcomingPackagesForSigningMap : ClassMap<OutcomingPackagesForSigning>
    {
        public OutcomingPackagesForSigningMap()
        {
            Table("Signatures");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.DocumentsGroupId);
            Map(x => x.DraftsGroupId);

            References(x => x.DraftsGroup).Column("DraftsGroupId");
            References(x => x.DocumentsGroup).Column("DocumentsGroupId");
        }
    }
}