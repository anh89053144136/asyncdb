using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ApiClients2DocumentMap : ClassMap<ApiClients2Document>
    {
        public ApiClients2DocumentMap()
        {
            Table("ApiClients2Documents");

            Map(x => x.SenderProgramInstanceId);
            Map(x => x.DocumentId);
            Map(x => x.IsContainsChanges);
        }
    }
}