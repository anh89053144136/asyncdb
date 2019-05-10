using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class SignatureMap : ClassMap<Signature>
    {
        public SignatureMap()
        {
            Table("Signatures");

            Id(x => x.Id).GeneratedBy.Guid();

            References(x => x.File).Column("FileId");
            References(x => x.Cert).Column("CertificateId");
        }
    }
}
