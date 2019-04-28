using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class ContactTransactionMap : ClassMap<ContactTransaction>
    {
        public ContactTransactionMap()
        {
            Table("ContactTransactions");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.PreviousState);
            Map(x => x.CurrentState);
            Map(x => x.ContactId);
            Map(x => x.EmployeeId);
            Map(x => x.CreateDateTime);
            Map(x => x.ClientChangeId);
            Map(x => x.Description);
        }
    }
}