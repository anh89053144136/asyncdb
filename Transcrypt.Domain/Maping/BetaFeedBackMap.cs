using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class BetaFeedBackMap : ClassMap<BetaFeedBack>
    {
        public BetaFeedBackMap()
        {
            Table("BetaFeedBacks");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.Comment);
            Map(x => x.Choice);
            Map(x => x.EmployeeId);
            Map(x => x.Email);
            Map(x => x.CreationDate);
        }
    }
}