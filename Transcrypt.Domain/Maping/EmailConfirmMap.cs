using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class EmailConfirmMap : ClassMap<EmailConfirm>
    {
        public EmailConfirmMap()
        {
            Table("EmailConfirms");

            Map(x => x.Secret);
            Map(x => x.Email);
            Map(x => x.UserId);
            Map(x => x.EmployeeId);
            Map(x => x.Date);
            Map(x => x.State);

            References(x => x.User).Column("UserId");
            References(x => x.Employee).Column("EmployeeId");
        }
        
    }
}