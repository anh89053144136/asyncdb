using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Table("Employees");

            Id(x => x.Id);

            Map(x => x.LastName);
            Map(x => x.FirstName);
            Map(x => x.MiddleName);
            Map(x => x.DepartmentId);
            Map(x => x.Post);
            Map(x => x.Email);
            Map(x => x.DocumentPermissionId);
            Map(x => x.IsAdmin);

            Map(x => x.IsAccessForLogin);
            Map(x => x.UserId);
            Map(x => x.State);
            Map(x => x.ClientId);
            Map(x => x.DealerPersonId);
            Map(x => x.Snils);
            Map(x => x.AllowedReceiveMessagesType);
            Map(x => x.AllowedReceiveMessagesTypeTranscrypt);

            Map(x => x.ProgramInstanceId);
            Map(x => x.CabinetType);
            Map(x => x.IsApprovalReviewer);
            Map(x => x.IsAuthorizedSigner);
            Map(x => x.AvatarSrc);
            Map(x => x.AvatarPreview);

            References(x => x.Department).Column("DepartamentId");
            References(x => x.User).Column("UserId");
            References(x => x.Client).Column("ClientId");
        }
	}
}

