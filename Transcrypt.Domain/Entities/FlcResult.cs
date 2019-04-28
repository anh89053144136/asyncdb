using System;

namespace Transcrypt.Domain.Entities
{
    public class FlcResult
    {
        public Guid Id { get; set; }

        public string Filename { get; set; }

        public int FileType { get; set; }

        public string Result { get; set; }
    }
}