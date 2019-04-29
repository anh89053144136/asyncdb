using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class OperatorMap : ClassMap<Operator>
    {
        public OperatorMap()
        {
            Table("Operators");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.DocflowUserId);
            Map(x => x.FullName);
            Map(x => x.Inn);
            Map(x => x.Kpp);
            Map(x => x.Type);
            Map(x => x.SignCertificateThumbprint);
        }
    }
}
