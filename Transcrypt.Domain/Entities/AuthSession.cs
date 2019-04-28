using System;

namespace Transcrypt.Domain.Entities
{
    public class AuthSession
    {
        public Guid Id { get; set; }

        public DateTime DateLogin  {get;set;}

        public string Login {get;set;}

        public string CertHash {get;set;}

        public string Ip {get;set;}

        public Guid? UserId {get;set;}

        public Guid? EmployeeId {get;set;}

        public DateTime DateLastActive {get;set;}

        public int Status {get;set;}

        public Guid? OperatorId {get;set;}

        public Guid? ProgramInstanceId {get;set;}

        public Guid? ProgramInfoId {get;set;}
        
        //[Association(ThisKey = "EmployeeId", OtherKey = "Id", CanBeNull = true)]
        public Employee Employee { get; set; }
    }
}
