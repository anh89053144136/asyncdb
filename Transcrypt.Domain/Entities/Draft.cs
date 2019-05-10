using System;

namespace Transcrypt.Domain.Entities
{
    public class Draft
    {
        public virtual Guid Id { get; set; }

        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        public virtual int DocflowTypeCode { get; set; }

        public virtual Guid GroupId { get; set; }

        public virtual string UnformalizedDocumentType { get; set; }

        public virtual Guid? SenderDepartmentId { get; set; }

        public virtual bool NeedResign { get; set; }

        public virtual string FileName { get; set; }

        public virtual int DraftState { get; set; }

        public virtual DateTime UpdateDateTime { get; set; }

        public virtual Guid? ReceiverDepartmentId { get; set; }

        public virtual int? InvoiceType { get; set; }

        public virtual bool IsEncrypted { get; set; }
        
        //[Association(ThisKey = "GroupId", OtherKey = "Id")]
        public virtual DraftGroup DraftGroup { get; set; }
        
        //[Association(ThisKey = "SenderDepartmentId", OtherKey = "Id")]
        public virtual Department SenderDepartment { get; set; }
        
        //[Association(ThisKey = "ReceiverDepartmentId", OtherKey = "Id")]
        public virtual Department ReceiverDepartment { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "Id")]
        public virtual FileContent FileContent { get; set; }
    }
}