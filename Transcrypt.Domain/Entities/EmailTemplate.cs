namespace Transcrypt.Domain.Entities
{
	public class EmailTemplate
	{
		public virtual int EmailType { get; set; }

		public virtual string Message { get; set; }

		public virtual string Subject { get; set; }
	}
}
