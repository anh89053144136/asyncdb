using System;

namespace Transcrypt.Domain.Entities
{
	public class EncryptedDataRecipient
	{
		public virtual Guid Id { get; set; }

		public virtual byte[] Content { get; set; }

		public virtual string IssuerName { get; set; }

		public virtual string SerialNumber { get; set; }

		public virtual Guid TransactionFileId { get; set; }

		public virtual string Thumbprint { get; set; }

		public virtual Guid OrganizationId { get; set; }
	}
}