using System;

namespace Transcrypt.Domain.Entities
{
    public class DocumentEvent
    {
        public virtual long Index { get; set; }

        public virtual DateTime Date { get; set; }

        public virtual int EventType { get; set; }

        public virtual int State { get; set; }
        
        public virtual string ObjectStateInfo { get; set; }
        
        public virtual int ReferenceType { get; set; }
        
        public virtual Guid ReferenceId { get; set; }
        
        public virtual Guid SenderId { get; set; }
        
        public virtual Guid ReceiverId { get; set; }
    }
}