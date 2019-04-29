using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ApiClients2DocumentMap : ClassMap<ApiClients2Document>
    {
        public ApiClients2DocumentMap()
        {
            Table("ApiClients2Document");

            Id(x => new { x.DocumentId, x.SenderProgramInstanceId });

            Map(x => x.SenderProgramInstanceId);
            Map(x => x.DocumentId);
            Map(x => x.IsContainsChanges);
        }
    }
}