using System;

namespace Transcrypt.Domain.Entities
{
    public class ContactTransaction
    {
        public virtual Guid Id { get; set; }

        public virtual int PreviousState { get; set; }

        public virtual int CurrentState { get; set; }

        public virtual Guid ContactId { get; set; }

        public virtual Guid EmployeeId { get; set; }

        public virtual DateTime CreateDateTime { get; set; }

        public virtual Guid ClientChangeId { get; set; }

        public virtual string Description { get; set; }
    }
}