using System;

namespace Transcrypt.Domain.Entities
{
    public class IncomingPackagesForSigning
    {
        public virtual Guid Id { get; set; }

        public virtual Guid DocumentId { get; set; }
    }
}