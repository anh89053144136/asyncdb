using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class OutcomingPackagesForSigningMap : ClassMap<OutcomingPackagesForSigning>
    {
        public OutcomingPackagesForSigningMap()
        {
            Table("OutcomingPackagesForSigning");

            Id(x => x.Id).GeneratedBy.Guid();

            References(x => x.DraftsGroup).Column("DraftsGroupId");
            References(x => x.DocumentsGroup).Column("DocumentsGroupId");
        }
    }
}