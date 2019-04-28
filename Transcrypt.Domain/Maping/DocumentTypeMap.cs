using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class DocumentTypeMap : ClassMap<DocumentType>
    {
        public DocumentTypeMap()
        {
            Table("DocumentTypes");

            Id(x => x.Code);

            Map(x => x.Name);
            Map(x => x.ShortName);
            Map(x => x.FileNamePattern);
            Map(x => x.TypeNamePattern);
        }
    }
}
