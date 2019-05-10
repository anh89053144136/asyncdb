using System;

namespace Transcrypt.Domain.Entities
{
    public class Country
    {
        public virtual Guid Guid { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
        public virtual string Code2 { get; set; }
        public virtual string Code3 { get; set; }
    }
}