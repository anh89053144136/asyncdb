using System;

namespace Transcrypt.Domain.Entities
{
    public class CertInfo
    {
        public int Id { get; set; }

        public string CommonName { get; set; }

        public DateTime? KeyDate { get; set; }

        public DateTime? ExpDate { get; set; }

        public string Snils { get; set; }

        public string Post { get; set; }

        public string Fio { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "Id")]
        public Cert Cert { get; set; }
    }
}
