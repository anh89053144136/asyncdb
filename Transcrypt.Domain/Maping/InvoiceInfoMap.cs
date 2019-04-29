using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class InvoiceInfoMap : ClassMap<InvoiceInfo>
    {
        public InvoiceInfoMap()
        {
            Table("Signatures");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.Number);
            Map(x => x.Date);
            Map(x => x.ParentNumber);
            Map(x => x.ParentDate);
            Map(x => x.CorrectionNumber);
            Map(x => x.RevisionNumber);
            Map(x => x.RevisionDate);
            Map(x => x.Type);
            Map(x => x.ParentRevisionNumber);
            Map(x => x.ParentRevisionDate);
        }
	}
}