using System;

namespace Transcrypt.Domain.Entities
{
    public class DocumentEvent
    {
        public long Index { get; set; }

        public DateTime Date { get; set; }

        public int EventType { get; set; }

        public int State { get; set; }
        
        public string ObjectStateInfo { get; set; }
        
        public int ReferenceType { get; set; }
        
        public Guid ReferenceId { get; set; }
        
        public Guid SenderId { get; set; }
        
        public Guid ReceiverId { get; set; }
    }
}