using System;

namespace Transcrypt.Domain.Entities
{
	public class InvoiceInfo
	{
		public virtual Guid Id { get; set; }

		public virtual string Number { get; set; }

		public virtual DateTime? Date { get; set; }

		public virtual string ParentNumber { get; set; }

		public virtual DateTime? ParentDate { get; set; }

		public virtual string CorrectionNumber { get; set; }

		public virtual string RevisionNumber { get; set; }

		public virtual DateTime? RevisionDate { get; set; }

		public virtual int Type { get; set; }

		public virtual string ParentRevisionNumber { get; set; }

		public virtual DateTime? ParentRevisionDate { get; set; }
	}
}