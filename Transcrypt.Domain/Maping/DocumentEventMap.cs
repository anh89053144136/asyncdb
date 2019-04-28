using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class DocumentEventMap : ClassMap<DocumentEvent>
    {
        public DocumentEventMap()
        {
            Table("DocumentEvents");

            Id(x => x.Index).GeneratedBy.Increment();

            Map(x => x.Date);
            Map(x => x.EventType);
            Map(x => x.State);
            Map(x => x.ObjectStateInfo);
            Map(x => x.ReferenceType);
            Map(x => x.ReferenceId);
            Map(x => x.SenderId);
            Map(x => x.ReceiverId);
        }
    }
}