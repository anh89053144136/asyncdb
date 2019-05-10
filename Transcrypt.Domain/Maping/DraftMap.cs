using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class DraftMap : ClassMap<Draft>
    {
        public DraftMap()
        {
            Table("Drafts");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.Title);
            Map(x => x.Description);
            Map(x => x.DocflowTypeCode);
            Map(x => x.UnformalizedDocumentType);
            Map(x => x.NeedResign);
            Map(x => x.FileName);
            Map(x => x.DraftState);
            Map(x => x.UpdateDateTime);
            Map(x => x.InvoiceType);
            Map(x => x.IsEncrypted);

            References(x => x.DraftGroup).Column("GroupId");
            References(x => x.SenderDepartment).Column("SenderDepartmentId");
            References(x => x.ReceiverDepartment).Column("ReceiverDepartmentId");
            //References(x => x.FileContent).Column("Id");
        }
    }
}