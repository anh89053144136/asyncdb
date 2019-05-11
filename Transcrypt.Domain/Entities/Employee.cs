using System;

namespace Transcrypt.Domain.Entities
{
	public class Employee
	{
		public virtual Guid Id {get;set;}

		public virtual string LastName {get;set;}

		public virtual string FirstName {get;set;}

		public virtual string MiddleName {get;set;}

		public virtual Guid? DepartmentId {get;set;}

		public virtual string Post {get;set;}

		public virtual string Email {get;set;}

		public virtual int DocumentPermissionId { get;set;}

		public virtual bool IsAdmin {get;set;}

		public virtual bool IsAccessForLogin {get;set;}

		public virtual int State {get;set;}

		public virtual int DealerPersonId {get;set;}

		public virtual string Snils {get;set;}

		public virtual int AllowedReceiveMessagesType {get; set;}

		public virtual int AllowedReceiveMessagesTypeTranscrypt {get; set;}

		public virtual Guid? ProgramInstanceId {get; set;}

		public virtual int CabinetType {get; set;}

		public virtual bool IsApprovalReviewer {get; set;}

		public virtual bool IsAuthorizedSigner {get; set;}
        
		//[Association(ThisKey = "DepartamentId", OtherKey = "Id", CanBeNull = true)]
		public virtual Department Department { get; set; }
        
		//[Association(ThisKey = "UserId", OtherKey = "Id", CanBeNull = true)]
		public virtual User User { get; set; }
        
		//[Association(ThisKey = "ClientId", OtherKey = "Id")]
		public virtual Client Client { get; set; }
		
		public virtual byte[] AvatarSrc { get; set; }
		public virtual byte[] AvatarPreview { get; set; }
	}
}

