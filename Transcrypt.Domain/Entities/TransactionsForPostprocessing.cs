using System;

namespace Transcrypt.Domain.Entities
{
    public class TransactionsForPostprocessing
    {
        public virtual Guid Id { get; set; }

        public virtual bool IsProcessed { get; set; }

        public virtual Guid DocumentId { get; set; }

        public virtual int TransactionType { get; set; }

        public virtual int DocflowType { get; set; }

        public virtual DateTime CreateDate { get; set; }
    }
}