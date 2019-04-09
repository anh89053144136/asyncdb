using System;
using System.Collections.Generic;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class Document
    {
        public Guid Id { get; set; }

        public Guid GroupId { get; set; }

        public Guid? SenderDepartmentId { get; set; }

        public Guid? ReceiverDepartmentId { get; set; }       

        public DateTime CreateDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }

        public int SenderState { get; set; }

        public int ReceiverState { get; set; }

        public DateTime? ReceivedDateTime { get; set; }

        public DateTime? SendConfirmDate { get; set; }

        public DateTime? ReceivConfirmDate { get; set; }

        public DateTime SendDateTime { get; set; }

        public string Title { get; set; }

        public int Code { get; set; }

        public string Description { get; set; }

        public bool NeedResign { get; set; }

        public bool IsSenderDeleted { get; set; }

        public bool IsReceiverDeleted { get; set; }

        public bool AllowNoticeSender { get; set; }

        public bool AllowNoticeReceiver { get; set; }

        public string UnformalizedType { get; set; }

        public Guid? ParentId { get; set; }              

        public Guid? ProgramInfoId { get; set; }

        public string Period { get; set; }

        public int DocumentTypeCode { get; set; }

        public bool IsEncrypted { get; set; }

        public int ReceiverTransactionFileCheckState { get; set; }

        public int SenderTransactionFileCheckState { get; set; }

        public bool SenderTransactionFileNeedCheck { get; set; }

        public bool ReceiverTransactionFileNeedCheck { get; set; }

        public Guid SenderId { get; set; }

        public Guid ReceiverId { get; set; }
        
        //[Association(ThisKey = "DocumentTypeCode", OtherKey = "Code")]
        public DocumentType TypeClass { get; set; }
        
        //[Association(ThisKey = "GroupId", OtherKey = "Id")]
        public DocumentGroup Group { get; set; }
        
        //[Association(ThisKey = "SenderDepartmentId", OtherKey = "Id", CanBeNull = true)]
        public Department SenderDepartment { get; set; }

        //[Association(ThisKey = "ReceiverDepartmentId", OtherKey = "Id", CanBeNull = true)]
        public Department ReceiverDepartment { get; set; }
        
        //[Association(ThisKey = "ParentId", OtherKey = "Id", CanBeNull = true)]
        public Document ParentDocument { get; set; }
        
        //[Association(ThisKey = "SenderId", OtherKey = "Id")]
        public Client Sender { get; set; }

        //[Association(ThisKey = "ReceiverId", OtherKey = "Id")]
        public Client Receiver { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "DocumentId")]
        public IEnumerable<EmployeeDocument> EmployeeDocuments { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "DocumentId")]
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
