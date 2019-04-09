using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
	public class Notification
	{
		public Guid Id { get; set; }
		public Guid OrganizationId { get; set; }
		public Guid? DepartmentId { get; set; }
		public Guid? EmployeeId { get; set; }
		public Guid? ReferenceId { get; set; }
		public DateTime Date { get; set; }
		public int State { get; set; }
		public int Type { get; set; }
	}
}