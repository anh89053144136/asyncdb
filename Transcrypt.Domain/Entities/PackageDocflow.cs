using System;

namespace Transcrypt.Domain.Entities
{
	public class PackageDocflow
	{
		public virtual Guid Id { get; set; }

		public virtual string TemplateId { get; set; }

		public virtual string SenderDocflowMemberId { get; set; }

		public virtual string ReceiverDocflowMemberId { get; set; }

		public virtual string Title { get; set; }

		public virtual DateTime? CreateDate { get; set; }

		public virtual DateTime? UpdateDate { get; set; }

		public virtual string StateType { get; set; }

		public virtual int StateSeverity { get; set; }

		public virtual string StateSenderName { get; set; }

		public virtual string StateReceiverName { get; set; }

		public virtual string TemplateName { get; set; }
	}
}