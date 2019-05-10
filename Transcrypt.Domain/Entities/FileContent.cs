using System;

namespace Transcrypt.Domain.Entities
{
    public class FileContent
    {
        public virtual Guid Id { get; set; }

        public virtual byte[] Content { get; set; }

        public virtual Guid? DataStorageId { get; set; }
    }
}
