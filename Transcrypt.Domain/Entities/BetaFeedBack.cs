using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
	public class BetaFeedBack
	{
		public Guid Id { get; set; }

		public string Comment { get; set; }

		public string Choice { get; set; }

		public Guid EmployeeId { get; set; }

		public string Email { get; set; }

		public DateTime? CreationDate { get; set; }
	}
}