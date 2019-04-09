using System;
using System.Collections.Generic;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class Transaction
    {
        public Guid Id { get; set; }
        
        public Guid DocumentId { get; set; }
        
        public Guid SenderId { get; set; }
        
        public Guid ReceiverId { get; set; }
        
        public bool SenderIsOperator { get; set; }
        
        public bool ReceiverIsOperator { get; set; }
        
        public int Code { get; set; }
        
        public DateTime CreateDate { get; set; }

        public Guid? ParentId { get; set; }
        
        //[Association(ThisKey = "SenderId", OtherKey = "Id")]
        public Client Sender { get; set; }

        //[Association(ThisKey = "ReceiverId", OtherKey = "Id")]
        public Client Receiver { get; set; }
        
        //[Association(ThisKey = "DocumentId", OtherKey = "Id")]
        public Document Document { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "TransactionId")]
        public IEnumerable<File> Files { get; set; }
    }
}
