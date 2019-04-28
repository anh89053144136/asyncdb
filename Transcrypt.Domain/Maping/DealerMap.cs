using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class DealerMap : ClassMap<Dealer>
    {
        public DealerMap()
        {
            Table("Dealers");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.OperatorId);
            Map(x => x.Name);
            Map(x => x.Code);
            Map(x => x.State);
        }
    }
}
