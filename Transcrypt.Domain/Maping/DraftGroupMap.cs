using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class DraftGroupMap : ClassMap<DraftGroup>
    {
        public DraftGroupMap()
        {
            Table("Signatures");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.CreateDateTime);
            Map(x => x.UpdateDateTime);
            Map(x => x.IsAutosaved);
            Map(x => x.EmployeeId);
            Map(x => x.Sent);

            References(x => x.Sender).Column("SenderId");
            References(x => x.Receiver).Column("ReceiverId");
            References(x => x.PrimarySenderDepartment).Column("PrimarySenderDepartmentId");
            References(x => x.PrimaryReceiverDepartment).Column("PrimaryReceiverDepartmentId");
        }
    }
}