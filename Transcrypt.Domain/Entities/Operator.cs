using System;

namespace Transcrypt.Domain.Entities
{
    public class Operator
    {
        public Guid Id { get; set; }

        public string DocflowUserId { get; set; }

        public string FullName { get; set; }

        public string Inn { get; set; }

        public string Kpp { get; set; }

        public int Type { get; set; }

        public string SignCertificateThumbprint { get; set; }
    }
}
