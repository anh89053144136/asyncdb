using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
	public class ForExport
	{
		public Guid Id { get; set; }

		public Guid TransactionId { get; set; }

		public int ClientType { get; set; }

		public int Status { get; set; }
	}
}