using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ApiClientsInfoMap : ClassMap<ApiClientsInfo>
    {
        public ApiClientsInfoMap()
        {
            Table("ApiClientsInfos");

            Id(x => x.ClientId);

            Map(x => x.RegistrationDateTime);
            Map(x => x.Settings);
            Map(x => x.Description);

            References(x => x.ProgramInfo).Column("ProgramInfoId");
        }
    }
}
