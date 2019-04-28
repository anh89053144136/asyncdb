using System;

namespace Transcrypt.Domain.Entities
{
    public class OperatorSettings
    {
        public int Id { get; set; }

        public Guid OperatorId { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
        
        //[Association(OtherKey = "Id", ThisKey = "OperatorId")]
        public Operator Operator { get; set; }
    }
}
