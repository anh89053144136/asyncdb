using System;

namespace Transcrypt.Domain.Entities
{
    public class Address
    {
        public virtual Guid Id { get; set; }

        public virtual int TypeId { get; set; }
    }
}