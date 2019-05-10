using System;

namespace Transcrypt.Domain.Entities
{
	public class EmailNotification
	{
		public virtual Guid Id { get; set; }
		public virtual Guid SenderOrganizationId { get; set; }
		public virtual Guid ReceiverOrganizationId { get; set; }
		public virtual Guid? ReceiverDepartamentId { get; set; }
		public virtual Guid ProgramInfoId { get; set; }
		public virtual Guid? ReceiverEmployeeId { get; set; }
		public virtual Guid? ReferenceId { get; set; }
		public virtual DateTime CreateDate { get; set; }
		public virtual bool IsSended { get; set; }
		public virtual int Type { get; set; }
	}
}