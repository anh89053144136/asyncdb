using System;

namespace Transcrypt.Domain.Entities
{
    public class OperatorSettings
    {
        public virtual int Id { get; set; }

        public virtual Guid OperatorId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Value { get; set; }
        
        //[Association(OtherKey = "Id", ThisKey = "OperatorId")]
        public virtual Operator Operator { get; set; }
    }
}
