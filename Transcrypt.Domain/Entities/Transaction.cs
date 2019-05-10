using System;
using System.Collections.Generic;

namespace Transcrypt.Domain.Entities
{
    public class Transaction
    {
        public virtual Guid Id { get; set; }
        
        public virtual Guid DocumentId { get; set; }
        
        public virtual Guid SenderId { get; set; }
        
        public virtual Guid ReceiverId { get; set; }
        
        public virtual bool SenderIsOperator { get; set; }
        
        public virtual bool ReceiverIsOperator { get; set; }
        
        public virtual int Code { get; set; }
        
        public virtual DateTime CreateDate { get; set; }

        public virtual Guid? ParentId { get; set; }
        
        //[Association(ThisKey = "SenderId", OtherKey = "Id")]
        public virtual Client Sender { get; set; }

        //[Association(ThisKey = "ReceiverId", OtherKey = "Id")]
        public virtual Client Receiver { get; set; }
        
        //[Association(ThisKey = "DocumentId", OtherKey = "Id")]
        public virtual Document Document { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "TransactionId")]
        public virtual IEnumerable<File> Files { get; set; }
    }
}
