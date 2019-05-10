using System;

namespace Transcrypt.Domain.Entities
{
    public class Signature
    {
        public virtual Guid Id { get; set; }
                
        public virtual Guid FileId { get; set; }
        
        public virtual int? CertificateId { get; set; }
        
        //[Association(ThisKey = "FileId", OtherKey = "Id")]
        public virtual File File { get; set; }
        
        //[Association(ThisKey = "CertificateId", OtherKey = "Id")]
        public virtual Cert Cert { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "Id")]
        public virtual FileContent FileContent { get; set; }
    }
}
