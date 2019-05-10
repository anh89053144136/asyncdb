using System;

namespace Transcrypt.Domain.Entities
{
    public class EmployeeDocument
    {
        public virtual Guid DocumentId { get; set; }

        public virtual Guid EmployeeId { get; set; }

        public virtual bool IsImportant { get; set; }

        public virtual bool NotReaded { get; set; }
        
        //[Association(ThisKey = "DocumentId", OtherKey = "Id")]
        public virtual Document Document { get; set; }
        
        //[Association(ThisKey = "EmployeeId", OtherKey = "Id")]
        public virtual Employee Employee { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as EmployeeDocument;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return this.DocumentId == other.DocumentId &&
                this.EmployeeId == other.EmployeeId;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 31) ^ DocumentId.GetHashCode();
                hash = (hash * 31) ^ EmployeeId.GetHashCode();

                return hash;
            }
        }
    }
}
