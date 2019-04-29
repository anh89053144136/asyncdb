using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class DocumentMap : ClassMap<Document>
    {
        public DocumentMap()
        {
            Table("Documents");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.CreateDateTime);
            Map(x => x.UpdateDateTime);
            Map(x => x.SenderState);
            Map(x => x.ReceiverState);
            Map(x => x.ReceivedDateTime);
            Map(x => x.SendConfirmDate);
            Map(x => x.ReceivConfirmDate);
            Map(x => x.SendDateTime);
            Map(x => x.Title);
            Map(x => x.Code);
            Map(x => x.Description);
            Map(x => x.NeedResign);
            Map(x => x.IsSenderDeleted);
            Map(x => x.IsReceiverDeleted);
            Map(x => x.AllowNoticeSender);
            Map(x => x.AllowNoticeReceiver);
            Map(x => x.UnformalizedType);
            Map(x => x.ProgramInfoId);
            Map(x => x.Period);
            Map(x => x.IsEncrypted);
            Map(x => x.ReceiverTransactionFileCheckState);
            Map(x => x.SenderTransactionFileCheckState);
            Map(x => x.SenderTransactionFileNeedCheck);
            Map(x => x.ReceiverTransactionFileNeedCheck);

            References(x => x.TypeClass).Column("DocumentTypeCode");
            References(x => x.Group).Column("GroupId");
            References(x => x.SenderDepartment).Column("SenderDepartmentId");
            References(x => x.ReceiverDepartment).Column("ReceiverDepartmentId");
            References(x => x.ParentDocument).Column("ParentId");
            References(x => x.Sender).Column("SenderId");
            References(x => x.Receiver).Column("ReceiverId");
        }
    }
}
