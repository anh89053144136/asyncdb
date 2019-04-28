using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class EmailNotificationMap : ClassMap<EmailNotification>
    {
        public EmailNotificationMap()
        {
            Table("Signatures");

            Id(x => x.Id);

            Map(x => x.SenderOrganizationId);
            Map(x => x.ReceiverOrganizationId);
            Map(x => x.ReceiverDepartamentId);
            Map(x => x.ProgramInfoId);
            Map(x => x.ReceiverEmployeeId);
            Map(x => x.ReferenceId);
            Map(x => x.CreateDate);
            Map(x => x.IsSended);
            Map(x => x.Type);
        }
        
    }
}