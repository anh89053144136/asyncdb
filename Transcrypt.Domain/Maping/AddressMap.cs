﻿using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Table("Address");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.TypeId);
        }
    }
}