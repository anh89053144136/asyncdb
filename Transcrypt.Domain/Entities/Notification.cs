using System;

namespace Transcrypt.Domain.Entities
{
	public class Notification
	{
		public virtual Guid Id { get; set; }
		public virtual Guid OrganizationId { get; set; }
		public virtual Guid? DepartmentId { get; set; }
		public virtual Guid? EmployeeId { get; set; }
		public virtual Guid? ReferenceId { get; set; }
		public virtual DateTime Date { get; set; }
		public virtual int State { get; set; }
		public virtual int Type { get; set; }
	}
}