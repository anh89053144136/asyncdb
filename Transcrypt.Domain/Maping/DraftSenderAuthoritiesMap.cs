using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class DraftSenderAuthoritiesMap : ClassMap<DraftSenderAuthorities>
    {
        public DraftSenderAuthoritiesMap()
        {
            Table("DraftSenderAuthoritiess");

            Id(x => x.Id);

            Map(x => x.Area);
            Map(x => x.Status);
            Map(x => x.BasisForOrganization);
            Map(x => x.BasisForEmployee);
            Map(x => x.Post);
            Map(x => x.StateRegistrationCertificate);
            Map(x => x.OtherInformation);
        }
    }
}