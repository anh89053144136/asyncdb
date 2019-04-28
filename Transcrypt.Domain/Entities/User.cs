using System;

namespace Transcrypt.Domain.Entities
{
	public class User
	{
		public Guid Id { get; set; }

		public string Login { get; set; }

		public string Password { get; set; }
	}
}
