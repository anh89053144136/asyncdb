using System;

namespace Transcrypt.Domain.Entities
{
    public class DocumentApproval
    {
        public virtual Guid Id { get; set; }
        public virtual Guid ApprovalPackageId { get; set; }
        public virtual Guid? DraftId { get; set; }
        public virtual Guid? DocumentId { get; set; }
    }
}