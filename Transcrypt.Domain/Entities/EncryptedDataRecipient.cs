using System;

namespace Transcrypt.Domain.Entities
{
	public class EncryptedDataRecipient
	{
		public Guid Id { get; set; }

		public byte[] Content { get; set; }

		public string IssuerName { get; set; }

		public string SerialNumber { get; set; }

		public Guid TransactionFileId { get; set; }

		public string Thumbprint { get; set; }

		public Guid OrganizationId { get; set; }
	}
}