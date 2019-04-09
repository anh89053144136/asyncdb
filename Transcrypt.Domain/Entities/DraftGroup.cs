using System;
using System.Collections.Generic;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class DraftGroup
    {
        public Guid Id { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }

        public Guid SenderId { get; set; }

        public Guid? ReceiverId { get; set; }

        public Guid? PrimarySenderDepartmentId { get; set; }

        public Guid? PrimaryReceiverDepartmentId { get; set; }

        public bool IsAutosaved { get; set; }

        public Guid? EmployeeId { get; set; }
        
        //[Association(ThisKey = "SenderId", OtherKey = "Id")]
        public Client Sender { get; set; }
        
        //[Association(ThisKey = "ReceiverId", OtherKey = "Id")]
        public Client Receiver { get; set; }
        
        //[Association(ThisKey = "PrimarySenderDepartmentId", OtherKey = "Id")]
        public Department PrimarySenderDepartment { get; set; }
        
        //[Association(ThisKey = "PrimaryReceiverDepartmentId", OtherKey = "Id")]
        public Department PrimaryReceiverDepartment { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "GroupId")]
        public IEnumerable<Draft> Drafts { get; set; }

        public bool Sent { get; set; }
    }
}