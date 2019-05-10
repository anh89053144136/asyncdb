using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class EmployeeShelfAccessMap : ClassMap<EmployeeShelfAccess>
    {
        public EmployeeShelfAccessMap()
        {
            Table("EmployeeShelfAccesss");

            CompositeId()
              .KeyProperty(x => x.EmployeeId)
              .KeyProperty(x => x.DataStorageId);
        }
    }
}