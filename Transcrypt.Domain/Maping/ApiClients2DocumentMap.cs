using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ApiClients2DocumentMap : ClassMap<ApiClients2Document>
    {
        public ApiClients2DocumentMap()
        {
            Table("ApiClients2Document");

            CompositeId()
              .KeyProperty(x => x.DocumentId)
              .KeyProperty(x => x.SenderProgramInstanceId);

            Map(x => x.IsContainsChanges);
        }
    }
}