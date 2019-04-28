using System;

namespace Transcrypt.Domain.Entities
{
    public class DocumentApproval
    {
        public Guid Id { get; set; }
        public Guid ApprovalPackageId { get; set; }
        public Guid? DraftId { get; set; }
        public Guid? DocumentId { get; set; }
    }
}