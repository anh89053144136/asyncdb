using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class DraftSenderAuthorities
    {
        public Guid Id { get; set; }

        public int Area { get; set; }

        public int Status { get; set; }

        public string BasisForOrganization { get; set; }

        public string BasisForEmployee { get; set; }

        public string Post { get; set; }
 
        public string StateRegistrationCertificate { get; set; }

        public string OtherInformation { get; set; }
    }
}