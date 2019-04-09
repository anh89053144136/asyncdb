namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class DocumentType
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public string FileNamePattern { get; set; }

        public string TypeNamePattern { get; set; }
    }
}
