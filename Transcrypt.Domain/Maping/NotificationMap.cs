using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class NotificationMap : ClassMap<Notification>
    {
        public NotificationMap()
        {
            Table("Signatures");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.OrganizationId);
            Map(x => x.DepartmentId);
            Map(x => x.EmployeeId);
            Map(x => x.ReferenceId);
            Map(x => x.Date);
            Map(x => x.State);
            Map(x => x.Type);
        }
	}
}