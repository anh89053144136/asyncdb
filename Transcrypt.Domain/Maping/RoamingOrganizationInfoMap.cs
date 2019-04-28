using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class RoamingOrganizationInfoMap : ClassMap<RoamingOrganizationInfo>
    {
        public RoamingOrganizationInfoMap()
        {
            Table("RoamingOrganizationInfos");

            Map(x => x.OrganizationId);
            Map(x => x.Mode);
        }
	}
}