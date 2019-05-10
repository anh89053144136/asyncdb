using System;

namespace Transcrypt.Domain.Entities
{
    public class FlcResult
    {
        public virtual Guid Id { get; set; }

        public virtual string Filename { get; set; }

        public virtual int FileType { get; set; }

        public virtual string Result { get; set; }
    }
}