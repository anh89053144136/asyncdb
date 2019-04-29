using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class AuthSessionMap : ClassMap<AuthSession>
    {
        public AuthSessionMap()
        {
            Table("AuthSessions");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.DateLogin);
            Map(x => x.Login);
            Map(x => x.CertHash);
            Map(x => x.Ip);
            Map(x => x.UserId);
            Map(x => x.EmployeeId);
            Map(x => x.DateLastActive);
            Map(x => x.Status);
            Map(x => x.OperatorId);
            Map(x => x.ProgramInstanceId);
            Map(x => x.ProgramInfoId);

            References(x => x.Employee).Column("EmployeeId");
        }
    }
}
