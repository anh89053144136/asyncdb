using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class IncomingPackagesForSigning
    {
        public Guid Id { get; set; }

        public Guid DocumentId { get; set; }
    }
}