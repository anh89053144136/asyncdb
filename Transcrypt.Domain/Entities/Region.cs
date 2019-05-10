using System;

namespace Transcrypt.Domain.Entities
{
    public class Region
    {
        public virtual Guid Id { get; set; }

        public virtual string Code { get; set; }

        public virtual string Name { get; set; }

        public virtual string ShortName { get; set; }
    }
}