using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class ForExportMap : ClassMap<ForExport>
    {
        public ForExportMap()
        {
            Table("ForExports");

            Id(x => x.Id);

            Map(x => x.TransactionId);
            Map(x => x.ClientType);
            Map(x => x.Status);
        }
	}
}