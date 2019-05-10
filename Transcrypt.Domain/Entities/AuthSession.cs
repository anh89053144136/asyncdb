using System;

namespace Transcrypt.Domain.Entities
{
    public class AuthSession
    {
        public virtual Guid Id { get; set; }

        public virtual DateTime DateLogin  {get;set;}

        public virtual string Login {get;set;}

        public virtual string CertHash {get;set;}

        public virtual string Ip {get;set;}

        public virtual Guid? UserId {get;set;}

        public virtual Guid? EmployeeId {get;set;}

        public virtual DateTime DateLastActive {get;set;}

        public virtual int Status {get;set;}

        public virtual Guid? OperatorId {get;set;}

        public virtual Guid? ProgramInstanceId {get;set;}

        public virtual Guid? ProgramInfoId {get;set;}
        
        //[Association(ThisKey = "EmployeeId", OtherKey = "Id", CanBeNull = true)]
        public virtual Employee Employee { get; set; }
    }
}
