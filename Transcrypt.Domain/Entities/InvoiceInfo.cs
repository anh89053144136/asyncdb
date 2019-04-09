using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
	public class InvoiceInfo
	{
		public Guid Id { get; set; }

		public string Number { get; set; }

		public DateTime? Date { get; set; }

		public string ParentNumber { get; set; }

		public DateTime? ParentDate { get; set; }

		public string CorrectionNumber { get; set; }

		public string RevisionNumber { get; set; }

		public DateTime? RevisionDate { get; set; }

		public int Type { get; set; }

		public string ParentRevisionNumber { get; set; }

		public DateTime? ParentRevisionDate { get; set; }
	}
}