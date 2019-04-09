using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class ApiClients2Document
    {
        public Guid SenderProgramInstanceId { get; set; }

        public Guid DocumentId { get; set; }

        public bool IsContainsChanges { get; set; }
    }
}