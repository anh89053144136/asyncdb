using System;

namespace Transcrypt.Domain.Entities
{
    public class ApiClients2Document
    {
        public virtual Guid SenderProgramInstanceId { get; set; }

        public virtual Guid DocumentId { get; set; }

        public virtual bool IsContainsChanges { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as ApiClients2Document;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return this.SenderProgramInstanceId == other.SenderProgramInstanceId &&
                this.DocumentId == other.DocumentId;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 31) ^ SenderProgramInstanceId.GetHashCode();
                hash = (hash * 31) ^ DocumentId.GetHashCode();

                return hash;
            }
        }
    }
}