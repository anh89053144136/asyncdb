using System;

namespace Transcrypt.Domain.Entities
{
    public class Operator
    {
        public virtual Guid Id { get; set; }

        public virtual string DocflowUserId { get; set; }

        public virtual string FullName { get; set; }

        public virtual string Inn { get; set; }

        public virtual string Kpp { get; set; }

        public virtual int Type { get; set; }

        public virtual string SignCertificateThumbprint { get; set; }
    }
}
