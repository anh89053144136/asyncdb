using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class IncomingPackagesForSigningMap : ClassMap<IncomingPackagesForSigning>
    {
        public IncomingPackagesForSigningMap()
        {
            Table("IncomingPackagesForSigning");

            Id(x => x.Id).GeneratedBy.Guid();

            References(x => x.Document).Column("DocumentId");
        }
    }
}