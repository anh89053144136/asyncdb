using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class TransactionForPostProcessingMap : ClassMap<TransactionForPostProcessing>
    {
        public TransactionForPostProcessingMap()
        {
            Table("TransactionForPostProcessings");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.IsProcessed);
            Map(x => x.DocumentId);
            Map(x => x.CreateDate);
            Map(x => x.TransactionType);
            Map(x => x.DocflowType);
        }
	}
}