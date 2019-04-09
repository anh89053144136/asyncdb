namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
	public class EmailTemplate
	{
		public int EmailType { get; set; }

		public string Message { get; set; }

		public string Subject { get; set; }
	}
}
