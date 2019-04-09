using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
	public class User
	{
		public Guid Id { get; set; }

		public string Login { get; set; }

		public string Password { get; set; }
	}
}
