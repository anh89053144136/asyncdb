using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class DocumentApproval
    {
        public Guid Id { get; set; }
        public Guid ApprovalPackageId { get; set; }
        public Guid? DraftId { get; set; }
        public Guid? DocumentId { get; set; }
    }
}