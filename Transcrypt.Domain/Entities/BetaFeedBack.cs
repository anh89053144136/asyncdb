using System;

namespace Transcrypt.Domain.Entities
{
	public class BetaFeedBack
	{
		public virtual Guid Id { get; set; }

		public virtual string Comment { get; set; }

		public virtual string Choice { get; set; }

		public virtual Guid EmployeeId { get; set; }

		public virtual string Email { get; set; }

		public virtual DateTime? CreationDate { get; set; }
	}
}