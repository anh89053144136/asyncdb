using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class EmployeeDocumentMap : ClassMap<EmployeeDocument>
    {
        public EmployeeDocumentMap()
        {
            Table("EmployeeDocumentInfos");

            CompositeId()
              .KeyReference(x => x.Document, "DocumentId")
              .KeyReference(x => x.Employee, "EmployeeId");

            Map(x => x.IsImportant).Column("IsImportant");
            Map(x => x.NotReaded).Column("IsNew");
        }
    }
}
