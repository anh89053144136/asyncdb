using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class PackageDocflowMap : ClassMap<PackageDocflow>
    {
        public PackageDocflowMap()
        {
            Table("PackageDocflows");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.TemplateId);
            Map(x => x.SenderDocflowMemberId);
            Map(x => x.ReceiverDocflowMemberId);
            Map(x => x.Title);
            Map(x => x.CreateDate);
            Map(x => x.UpdateDate);
            Map(x => x.StateType);
            Map(x => x.StateSeverity);
            Map(x => x.StateSenderName);
            Map(x => x.StateReceiverName);
            Map(x => x.TemplateName);
        }
	}
}