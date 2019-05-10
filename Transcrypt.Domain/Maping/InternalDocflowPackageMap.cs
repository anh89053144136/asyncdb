using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class InternalDocflowPackageMap : ClassMap<InternalDocflowPackage>
    {
        public InternalDocflowPackageMap()
        {
            Table("InternalDocflowPackages");

            Id(x => x.Id);//.GeneratedBy.Guid();

            Map(x => x.ReceiverId);
            Map(x => x.ReceiverDepartmentId);
            Map(x => x.ReceiverType);
            Map(x => x.CreationDate);
            Map(x => x.CreationComment);
            Map(x => x.ProcessingDate);
            Map(x => x.ProcessingComment);
            Map(x => x.State);
            Map(x => x.Type);
            Map(x => x.UpdateDate);

            //[Association(ThisKey = "Id", OtherKey = "Id", CanBeNull = true)]
            //References(x => x.ApprovalPackage).Column("Id");
            //[Association(ThisKey = "Id", OtherKey = "Id", CanBeNull = true)]
            //References(x => x.OutcomingPackageForSigning).Column("Id");
            //References(x => x.IncomingPackageForSigning).Column("Id");
            References(x => x.Sender).Column("SenderId");
        }
    }
}