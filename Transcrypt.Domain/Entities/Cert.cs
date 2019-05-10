using System;

namespace Transcrypt.Domain.Entities
{
    public class Cert
    {
        public virtual int Id { get; set; }

        public virtual string Hash { get; set; }

        public virtual Guid? ClientId { get; set; }

        public virtual string Content { get; set; }

        public virtual int State { get; set; }

        public virtual string IssuerName { get; set; }

        public virtual string SerialNumber { get; set; }
        
        //[Association(ThisKey = "ClientId", OtherKey = "Id")]
        public virtual Client Client { get; set; }
    }
}
