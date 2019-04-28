using System;

namespace Transcrypt.Domain.Entities
{
    public class ProgramInfo
    {
        public Guid Id { get; set; }

        public string Identity { get; set; }

        public string Name { get; set; }

        public Guid OperatorId { get; set; }

        public int Type { get; set; }
    }
}
