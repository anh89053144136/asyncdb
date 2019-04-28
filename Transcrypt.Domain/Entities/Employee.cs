using System;

namespace Transcrypt.Domain.Entities
{
	public class Employee
	{
		public Guid Id {get;set;}

		public string LastName {get;set;}

		public string FirstName {get;set;}

		public string MiddleName {get;set;}

		public Guid? DepartmentId {get;set;}

		public string Post {get;set;}

		public string Email {get;set;}

		public int DocumentPermissionId { get;set;}

		public bool IsAdmin {get;set;}

		public bool IsAccessForLogin {get;set;}

		public Guid? UserId {get;set;}

		public int State {get;set;}

		public Guid ClientId {get;set;}

		public int DealerPersonId {get;set;}

		public string Snils {get;set;}

		public int AllowedReceiveMessagesType {get; set;}

		public int AllowedReceiveMessagesTypeTranscrypt {get; set;}

		public Guid? ProgramInstanceId {get; set;}

		public int CabinetType {get; set;}

		public bool IsApprovalReviewer {get; set;}

		public bool IsAuthorizedSigner {get; set;}
        
		//[Association(ThisKey = "DepartamentId", OtherKey = "Id", CanBeNull = true)]
		public Department Department { get; set; }
        
		//[Association(ThisKey = "UserId", OtherKey = "Id", CanBeNull = true)]
		public User User { get; set; }
        
		//[Association(ThisKey = "ClientId", OtherKey = "Id")]
		public Client Client { get; set; }
		
		public byte[] AvatarSrc { get; set; }
		public byte[] AvatarPreview { get; set; }
	}
}

