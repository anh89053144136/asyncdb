using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class RoamingTransactionMap : ClassMap<RoamingTransaction>
    {
        public RoamingTransactionMap()
        {
            Table("RoamingTransactions");

            Map(x => x.TransactionId);
            Map(x => x.State);
            Map(x => x.WithParentDocument);
            Map(x => x.Description);
            Map(x => x.RoamingMode);
        }
	}
}