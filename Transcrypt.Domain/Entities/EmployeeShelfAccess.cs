using System;

namespace Transcrypt.Domain.Entities
{
    public class EmployeeShelfAccess
    {
        public Guid EmployeeId { get; set; }

        public Guid DataStorageId { get; set; }
    }
}