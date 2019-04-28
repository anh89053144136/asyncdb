using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class EncryptedDataRecipientMap : ClassMap<EncryptedDataRecipient>
    {
        public EncryptedDataRecipientMap()
        {
            Table("EncryptedDataRecipients");

            Id(x => x.Id);

            Map(x => x.Content);
            Map(x => x.IssuerName);
            Map(x => x.SerialNumber);
            Map(x => x.TransactionFileId);
            Map(x => x.Thumbprint);
            Map(x => x.OrganizationId);
        }
	}
}