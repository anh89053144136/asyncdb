using System;
using System.Collections.Generic;

namespace Transcrypt.Domain.Entities
{
    public class DraftGroup
    {
        public virtual Guid Id { get; set; }

        public virtual DateTime CreateDateTime { get; set; }

        public virtual DateTime UpdateDateTime { get; set; }

        public virtual Guid SenderId { get; set; }

        public virtual Guid? ReceiverId { get; set; }

        public virtual Guid? PrimarySenderDepartmentId { get; set; }

        public virtual Guid? PrimaryReceiverDepartmentId { get; set; }

        public virtual bool IsAutosaved { get; set; }

        public virtual Guid? EmployeeId { get; set; }
        
        //[Association(ThisKey = "SenderId", OtherKey = "Id")]
        public virtual Client Sender { get; set; }
        
        //[Association(ThisKey = "ReceiverId", OtherKey = "Id")]
        public virtual Client Receiver { get; set; }
        
        //[Association(ThisKey = "PrimarySenderDepartmentId", OtherKey = "Id")]
        public virtual Department PrimarySenderDepartment { get; set; }
        
        //[Association(ThisKey = "PrimaryReceiverDepartmentId", OtherKey = "Id")]
        public virtual Department PrimaryReceiverDepartment { get; set; }
        
        //[Association(ThisKey = "Id", OtherKey = "GroupId")]
        public virtual IEnumerable<Draft> Drafts { get; set; }

        public virtual bool Sent { get; set; }
    }
}