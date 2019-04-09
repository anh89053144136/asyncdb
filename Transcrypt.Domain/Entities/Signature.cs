using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class Signature
    {
        public Guid Id { get; set; }
                
        public Guid FileId { get; set; }
        
        public int? CertificateId { get; set; }
        
        //[Association(ThisKey = "FileId", OtherKey = "Id")]
        public File File { get; set; }
        
        //[Association(ThisKey = "CertificateId", OtherKey = "Id")]
        public Cert Cert { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "Id")]
        public FileContent FileContent { get; set; }
    }
}
