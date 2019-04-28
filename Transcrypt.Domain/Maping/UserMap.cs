﻿using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");

            Id(x => x.Id);//.GeneratedBy.Increment();

            Map(x => x.Login);
            Map(x => x.Password);
        }
	}
}
