using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class IncomingPackagesForSigningMap : ClassMap<IncomingPackagesForSigning>
    {
        public IncomingPackagesForSigningMap()
        {
            Table("IncomingPackagesForSignings");

            Id(x => x.Id);//.GeneratedBy.Guid();

            Map(x => x.DocumentId);
        }
    }
}