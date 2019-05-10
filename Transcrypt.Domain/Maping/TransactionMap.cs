using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class TransactionMap : ClassMap<Transaction>
    {
        public TransactionMap()
        {
            Table("Transactions");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.SenderIsOperator);
            Map(x => x.ReceiverIsOperator);
            Map(x => x.CreateDate);
            Map(x => x.ParentId);
            Map(x => x.Code);

            References(x => x.Sender).Column("SenderId");
            References(x => x.Receiver).Column("ReceiverId");
            References(x => x.Document).Column("DocumentId");
        }
    }
}
