using System;

namespace Transcrypt.Domain.Entities
{
	public class RoamingTransaction
	{
		public virtual Guid TransactionId { get; set; }

		public virtual int State { get; set; }

		public virtual bool WithParentDocument { get; set; }

		public virtual string Description { get; set; }

		public virtual int RoamingMode { get; set; }
	}
}