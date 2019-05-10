using System;

namespace Transcrypt.Domain.Entities
{
    public class File
    {
        public virtual Guid Id { get; set; }

        public virtual Guid TransactionId { get; set; }

        public virtual string FileName { get; set; }

        public virtual int Size { get; set; }

        public virtual int Code { get; set; }

        public virtual bool IsEncrypted { get; set; }

        public virtual bool NeedCheckFlc { get; set; }

        public virtual bool NeedCheckSign { get; set; }

        public virtual int CheckState { get; set; }
        
        //[Association(ThisKey = "TransactionId", OtherKey = "Id")]
        public virtual Transaction Transaction { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "Id")]
        public virtual FileContent FileContent { get; set; }
    }
}
