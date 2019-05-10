using System;

namespace Transcrypt.Domain.Entities
{
	public class ForExport
	{
		public virtual Guid Id { get; set; }

		public virtual Guid TransactionId { get; set; }

		public virtual int ClientType { get; set; }

		public virtual int Status { get; set; }
	}
}