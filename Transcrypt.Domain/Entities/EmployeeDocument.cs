using System;

namespace Transcrypt.Domain.Entities
{
    public class EmployeeDocument
    {
        public virtual bool IsImportant { get; set; }

        public virtual bool NotReaded { get; set; }
        
        public virtual Document Document { get; set; }
        
        public virtual Employee Employee { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as EmployeeDocument;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return this.Document.Id == other.Document.Id &&
                this.Employee.Id == other.Employee.Id;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 31) ^ Document.Id.GetHashCode();
                hash = (hash * 31) ^ Employee.Id.GetHashCode();

                return hash;
            }
        }
    }
}
