using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class EmployeeShelfAccessMap : ClassMap<EmployeeShelfAccess>
    {
        public EmployeeShelfAccessMap()
        {
            Table("EmployeeShelfAccesss");

            Map(x => x.EmployeeId);
            Map(x => x.DataStorageId);
        }
    }
}