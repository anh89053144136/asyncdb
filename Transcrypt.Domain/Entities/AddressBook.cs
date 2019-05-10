using System;

namespace Transcrypt.Domain.Entities
{
    public class AddressBook
    {
        public virtual Guid Id { get; set; }

        public virtual Guid ContactSender { get; set; }

        public virtual Guid ContactReceiver { get; set; }

        public virtual int State { get; set; }

        public virtual string Description { get; set; }

        public virtual bool IsSystem { get; set; }

        public virtual bool IsRoaming { get; set; }

        public virtual DateTime CreateDateTime { get; set; }

        public virtual DateTime UpdateDateTime { get; set; }
    }
}