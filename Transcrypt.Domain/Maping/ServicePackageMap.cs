using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ServicePackageMap : ClassMap<ServicePackage>
    {
        public ServicePackageMap()
        {
            Table("ServicePackages");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.ClientId);
            Map(x => x.SendingsLimit);
            Map(x => x.TimeLimit);
            Map(x => x.TimeLimitType);
            Map(x => x.ExpirationDate);
            Map(x => x.Description);
            Map(x => x.ActivationDate);
            Map(x => x.SentCount);
            Map(x => x.State);
            Map(x => x.CreateDate);
            Map(x => x.CountExpiredDate);
            Map(x => x.MessageUnitType);
            Map(x => x.Type);
        }
    }
}