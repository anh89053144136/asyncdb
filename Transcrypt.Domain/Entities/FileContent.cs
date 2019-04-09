using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class FileContent
    {
        public Guid Id { get; set; }

        public byte[] Content { get; set; }

        public Guid? DataStorageId { get; set; }
    }
}
