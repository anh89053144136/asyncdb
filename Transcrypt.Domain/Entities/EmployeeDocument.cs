using System;

namespace Transcrypt.Domain.Entities
{
    public class EmployeeDocument
    {
        public Guid DocumentId { get; set; }

        public Guid EmployeeId { get; set; }

        public bool IsImportant { get; set; }

        public bool NotReaded { get; set; }
        
        //[Association(ThisKey = "DocumentId", OtherKey = "Id")]
        public Document Document { get; set; }
        
        //[Association(ThisKey = "EmployeeId", OtherKey = "Id")]
        public Employee Employee { get; set; }
    }
}
