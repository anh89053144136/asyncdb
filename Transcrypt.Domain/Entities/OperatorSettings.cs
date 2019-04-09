using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
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
