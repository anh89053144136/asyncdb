using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class Draft
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int DocflowTypeCode { get; set; }

        public Guid GroupId { get; set; }

        public string UnformalizedDocumentType { get; set; }

        public Guid? SenderDepartmentId { get; set; }

        public bool NeedResign { get; set; }

        public string FileName { get; set; }

        public int DraftState { get; set; }

        public DateTime UpdateDateTime { get; set; }

        public Guid? ReceiverDepartmentId { get; set; }

        public int? InvoiceType { get; set; }

        public bool IsEncrypted { get; set; }
        
        //[Association(ThisKey = "GroupId", OtherKey = "Id")]
        public DraftGroup DraftGroup { get; set; }
        
        //[Association(ThisKey = "SenderDepartmentId", OtherKey = "Id")]
        public Department SenderDepartment { get; set; }
        
        //[Association(ThisKey = "ReceiverDepartmentId", OtherKey = "Id")]
        public Department ReceiverDepartment { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "Id")]
        public FileContent FileContent { get; set; }
    }
}