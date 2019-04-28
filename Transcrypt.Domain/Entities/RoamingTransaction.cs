using System;

namespace Transcrypt.Domain.Entities
{
	public class RoamingTransaction
	{
		public Guid TransactionId { get; set; }

		public int State { get; set; }

		public bool WithParentDocument { get; set; }

		public string Description { get; set; }

		public int RoamingMode { get; set; }
	}
}