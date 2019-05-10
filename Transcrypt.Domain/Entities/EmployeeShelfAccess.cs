using System;

namespace Transcrypt.Domain.Entities
{
    public class EmployeeShelfAccess
    {
        public virtual Guid EmployeeId { get; set; }

        public virtual Guid DataStorageId { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as EmployeeShelfAccess;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return this.EmployeeId == other.EmployeeId &&
                this.DataStorageId == other.DataStorageId;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 31) ^ EmployeeId.GetHashCode();
                hash = (hash * 31) ^ DataStorageId.GetHashCode();

                return hash;
            }
        }
    }
}