using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
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
