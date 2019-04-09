using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class EmployeeShelfAccess
    {
        public Guid EmployeeId { get; set; }

        public Guid DataStorageId { get; set; }
    }
}