using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class IncomingPackagesForSigningMap : ClassMap<IncomingPackagesForSigning>
    {
        public IncomingPackagesForSigningMap()
        {
            Table("Signatures");

            Id(x => x.Id);//.GeneratedBy.Increment();

            Map(x => x.DocumentId);
        }
    }
}