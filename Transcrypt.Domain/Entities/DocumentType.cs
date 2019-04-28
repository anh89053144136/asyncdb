namespace Transcrypt.Domain.Entities
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
