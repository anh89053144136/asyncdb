using System;

namespace Transcrypt.Domain.Entities
{
    public class CertInfo
    {
        public virtual int Id { get; set; }

        public virtual string CommonName { get; set; }

        public virtual DateTime? KeyDate { get; set; }

        public virtual DateTime? ExpDate { get; set; }

        public virtual string Snils { get; set; }

        public virtual string Post { get; set; }

        public virtual string Fio { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "Id")]
        public virtual Cert Cert { get; set; }
    }
}
