using System;

namespace Transcrypt.Domain.Entities
{
    public class ApiClients2Document
    {
        public Guid SenderProgramInstanceId { get; set; }

        public Guid DocumentId { get; set; }

        public bool IsContainsChanges { get; set; }
    }
}