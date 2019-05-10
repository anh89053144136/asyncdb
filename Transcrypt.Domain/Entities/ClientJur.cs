using System;

namespace Transcrypt.Domain.Entities
{
	public class ClientJur
	{
		public virtual Guid Id { get; set; }
		public virtual string FullName { get; set; }
		public virtual string ShortName { get; set; }
		public virtual string Inn { get; set; }
		public virtual string Kpp { get; set; }
		public virtual string Ogrn { get; set; }
	}
}
