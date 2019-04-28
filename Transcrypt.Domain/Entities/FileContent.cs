using System;

namespace Transcrypt.Domain.Entities
{
    public class FileContent
    {
        public Guid Id { get; set; }

        public byte[] Content { get; set; }

        public Guid? DataStorageId { get; set; }
    }
}
