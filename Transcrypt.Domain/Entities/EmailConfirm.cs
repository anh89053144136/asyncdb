using System;

namespace Transcrypt.Domain.Entities
{
    public class EmailConfirm
    { 
        public virtual Guid Secret { get; set; }
        public virtual string Email { get; set; }
        public virtual Guid? UserId { get; set; }
        public virtual Guid? EmployeeId { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual byte State { get; set; }
        //[Association(ThisKey = "UserId",OtherKey = "Id")]
        public virtual User User { get; set; }
        //[Association(ThisKey = "EmployeeId",OtherKey = "Id")]
        public virtual Employee Employee { get; set; }
    }
}