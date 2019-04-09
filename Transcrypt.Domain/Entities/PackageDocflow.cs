using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
	public class PackageDocflow
	{
		public Guid Id { get; set; }

		public string TemplateId { get; set; }

		public string SenderDocflowMemberId { get; set; }

		public string ReceiverDocflowMemberId { get; set; }

		public string Title { get; set; }

		public DateTime? CreateDate { get; set; }

		public DateTime? UpdateDate { get; set; }

		public string StateType { get; set; }

		public int StateSeverity { get; set; }

		public string StateSenderName { get; set; }

		public string StateReceiverName { get; set; }

		public string TemplateName { get; set; }
	}
}