using System;

namespace Transcrypt.Domain.Entities
{
    public class Dealer
    {
        public virtual Guid Id { get; set; }

        public virtual Guid OperatorId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Code { get; set; }

        public virtual int State { get; set; }
    }
}
