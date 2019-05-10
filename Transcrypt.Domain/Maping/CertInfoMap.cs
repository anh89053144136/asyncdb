using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class CertInfoMap : ClassMap<CertInfo>
    {
        public CertInfoMap()
        {
            Table("CertInfos");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.CommonName);
            Map(x => x.KeyDate);
            Map(x => x.ExpDate);
            Map(x => x.Snils);
            Map(x => x.Post);
            Map(x => x.Fio);

            //References(x => x.Cert).Column("Id");
        }
    }
}
