using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class EmailConfirm
    { 
        public Guid Secret { get; set; }
        public string Email { get; set; }
        public Guid? UserId { get; set; }
        public Guid? EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public byte State { get; set; }
        //[Association(ThisKey = "UserId",OtherKey = "Id")]
        public User User { get; set; }
        //[Association(ThisKey = "EmployeeId",OtherKey = "Id")]
        public Employee Employee { get; set; }
    }
}