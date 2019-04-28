using System;

namespace Transcrypt.Domain.Entities
{
    public class File
    {
        public Guid Id { get; set; }

        public Guid TransactionId { get; set; }

        public string FileName { get; set; }

        public int Size { get; set; }

        public int Code { get; set; }

        public bool IsEncrypted { get; set; }

        public bool NeedCheckFlc { get; set; }

        public bool NeedCheckSign { get; set; }

        public int CheckState { get; set; }
        
        //[Association(ThisKey = "TransactionId", OtherKey = "Id")]
        public Transaction Transaction { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "Id")]
        public FileContent FileContent { get; set; }
    }
}
