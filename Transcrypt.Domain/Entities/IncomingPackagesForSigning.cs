using System;

namespace Transcrypt.Domain.Entities
{
    public class IncomingPackagesForSigning
    {
        public Guid Id { get; set; }

        public Guid DocumentId { get; set; }
    }
}