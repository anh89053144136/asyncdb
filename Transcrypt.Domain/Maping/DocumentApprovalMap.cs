using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class DocumentApprovalMap : ClassMap<DocumentApproval>
    {
        public DocumentApprovalMap()
        {
            Table("DocumentApprovals");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.ApprovalPackageId);
            Map(x => x.DraftId);
            Map(x => x.DocumentId);
        }
    }
}