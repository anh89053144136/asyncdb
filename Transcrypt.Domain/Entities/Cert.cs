using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class Cert
    {
        public int Id { get; set; }

        public string Hash { get; set; }

        public Guid? ClientId { get; set; }

        public string Content { get; set; }

        public int State { get; set; }

        public string IssuerName { get; set; }

        public string SerialNumber { get; set; }
        
        //[Association(ThisKey = "ClientId", OtherKey = "Id")]
        public Client Client { get; set; }
    }
}
