using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class CertMap : ClassMap<Cert>
    {
        public CertMap()
        {
            Table("Certs");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.Hash);
            Map(x => x.Content);
            Map(x => x.State);
            Map(x => x.IssuerName);
            Map(x => x.SerialNumber);

            References(x => x.Client).Column("ClientId");
        }
    }
}
