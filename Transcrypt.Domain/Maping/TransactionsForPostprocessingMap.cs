using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class TransactionsForPostprocessingMap : ClassMap<TransactionsForPostprocessing>
    {
        public TransactionsForPostprocessingMap()
        {
            Table("TransactionsForPostprocessings");

            Id(x => x.Id);//.GeneratedBy.Guid();

            Map(x => x.IsProcessed);
            Map(x => x.DocumentId);
            Map(x => x.TransactionType);
            Map(x => x.DocflowType);
            Map(x => x.CreateDate);
        }
    }
}