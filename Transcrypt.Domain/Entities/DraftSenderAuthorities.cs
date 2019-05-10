using System;

namespace Transcrypt.Domain.Entities
{
    public class DraftSenderAuthorities
    {
        public virtual Guid Id { get; set; }

        public virtual int Area { get; set; }

        public virtual int Status { get; set; }

        public virtual string BasisForOrganization { get; set; }

        public virtual string BasisForEmployee { get; set; }

        public virtual string Post { get; set; }
 
        public virtual string StateRegistrationCertificate { get; set; }

        public virtual string OtherInformation { get; set; }
    }
}