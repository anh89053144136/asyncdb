﻿using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class EmployeeDocumentMap : ClassMap<EmployeeDocument>
    {
        public EmployeeDocumentMap()
        {
            Table("EmployeeDocuments");

            Map(x => x.DocumentId);
            Map(x => x.EmployeeId);
            Map(x => x.IsImportant);
            Map(x => x.NotReaded);

            References(x => x.Document).Column("DocumentId");
            References(x => x.Employee).Column("EmployeeId");
            //References(x => x.FileContent).Column("DocumentId");
        }
    }
}