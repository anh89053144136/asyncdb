using System;

namespace Transcrypt.Domain.Entities
{
	public class EmailNotification
	{
		public Guid Id { get; set; }
		public Guid SenderOrganizationId { get; set; }
		public Guid ReceiverOrganizationId { get; set; }
		public Guid? ReceiverDepartamentId { get; set; }
		public Guid ProgramInfoId { get; set; }
		public Guid? ReceiverEmployeeId { get; set; }
		public Guid? ReferenceId { get; set; }
		public DateTime CreateDate { get; set; }
		public bool IsSended { get; set; }
		public int Type { get; set; }
	}
}