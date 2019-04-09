using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class ContactTransaction
    {
        public Guid Id { get; set; }

        public int PreviousState { get; set; }

        public int CurrentState { get; set; }

        public Guid ContactId { get; set; }

        public Guid EmployeeId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public Guid ClientChangeId { get; set; }

        public string Description { get; set; }
    }
}