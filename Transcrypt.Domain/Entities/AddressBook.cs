using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class AddressBook
    {
        public Guid Id { get; set; }

        public Guid ContactSender { get; set; }

        public Guid ContactReceiver { get; set; }

        public int State { get; set; }

        public string Description { get; set; }

        public bool IsSystem { get; set; }

        public bool IsRoaming { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }
    }
}