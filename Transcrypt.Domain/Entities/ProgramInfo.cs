using System;

namespace Transcrypt.Domain.Entities
{
    public class ProgramInfo
    {
        public virtual Guid Id { get; set; }

        public virtual string Identity { get; set; }

        public virtual string Name { get; set; }

        public virtual Guid OperatorId { get; set; }

        public virtual int Type { get; set; }
    }
}
