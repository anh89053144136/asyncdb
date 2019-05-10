namespace Transcrypt.Domain.Entities
{
    public class DocumentType
    {
        public virtual int Code { get; set; }

        public virtual string Name { get; set; }

        public virtual string ShortName { get; set; }

        public virtual string FileNamePattern { get; set; }

        public virtual string TypeNamePattern { get; set; }
    }
}
