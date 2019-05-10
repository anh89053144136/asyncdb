using System;
using System.Collections.Generic;

namespace Transcrypt.Domain.Entities
{
    public class Document
    {
        public virtual Guid Id { get; set; }

        public virtual Guid GroupId { get; set; }

        public virtual Guid? SenderDepartmentId { get; set; }

        public virtual Guid? ReceiverDepartmentId { get; set; }       

        public virtual DateTime CreateDateTime { get; set; }

        public virtual DateTime UpdateDateTime { get; set; }

        public virtual int SenderState { get; set; }

        public virtual int ReceiverState { get; set; }

        public virtual DateTime? ReceivedDateTime { get; set; }

        public virtual DateTime? SendConfirmDate { get; set; }

        public virtual DateTime? ReceivConfirmDate { get; set; }

        public virtual DateTime SendDateTime { get; set; }

        public virtual string Title { get; set; }

        public virtual int Code { get; set; }

        public virtual string Description { get; set; }

        public virtual bool NeedResign { get; set; }

        public virtual bool IsSenderDeleted { get; set; }

        public virtual bool IsReceiverDeleted { get; set; }

        public virtual bool AllowNoticeSender { get; set; }

        public virtual bool AllowNoticeReceiver { get; set; }

        public virtual string UnformalizedType { get; set; }

        public virtual Guid? ParentId { get; set; }              

        public virtual Guid? ProgramInfoId { get; set; }

        public virtual string Period { get; set; }

        public virtual int DocumentTypeCode { get; set; }

        public virtual bool IsEncrypted { get; set; }

        public virtual int ReceiverTransactionFileCheckState { get; set; }

        public virtual int SenderTransactionFileCheckState { get; set; }

        public virtual bool SenderTransactionFileNeedCheck { get; set; }

        public virtual bool ReceiverTransactionFileNeedCheck { get; set; }

        public virtual Guid SenderId { get; set; }

        public virtual Guid ReceiverId { get; set; }
        
        //[Association(ThisKey = "DocumentTypeCode", OtherKey = "Code")]
        public virtual DocumentType TypeClass { get; set; }
        
        //[Association(ThisKey = "GroupId", OtherKey = "Id")]
        public virtual DocumentGroup Group { get; set; }
        
        //[Association(ThisKey = "SenderDepartmentId", OtherKey = "Id", CanBeNull = true)]
        public virtual Department SenderDepartment { get; set; }

        //[Association(ThisKey = "ReceiverDepartmentId", OtherKey = "Id", CanBeNull = true)]
        public virtual Department ReceiverDepartment { get; set; }
        
        //[Association(ThisKey = "ParentId", OtherKey = "Id", CanBeNull = true)]
        public virtual Document ParentDocument { get; set; }
        
        //[Association(ThisKey = "SenderId", OtherKey = "Id")]
        public virtual Client Sender { get; set; }

        //[Association(ThisKey = "ReceiverId", OtherKey = "Id")]
        public virtual Client Receiver { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "DocumentId")]
        public virtual IEnumerable<EmployeeDocument> EmployeeDocuments { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "DocumentId")]
        public virtual IEnumerable<Transaction> Transactions { get; set; }
    }
}
