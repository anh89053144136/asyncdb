using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class DocumentGroupMap : ClassMap<DocumentGroup>
    {
        public DocumentGroupMap()
        {
            Table("DocumentGroups");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.State);
            Map(x => x.CreateDateTime);
            Map(x => x.UpdateDateTime);
            Map(x => x.ReceivedDateTime);
            Map(x => x.SendDateTime);

            References(x => x.Sender).Column("SenderId");
            References(x => x.Receiver).Column("ReceiverId");
        }
	}
}
