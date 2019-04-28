using System;

namespace Transcrypt.Domain.Entities
{
	public class ClientJur
	{
		public Guid Id { get; set; }
		public string FullName { get; set; }
		public string ShortName { get; set; }
		public string Inn { get; set; }
		public string Kpp { get; set; }
		public string Ogrn { get; set; }
	}
}
