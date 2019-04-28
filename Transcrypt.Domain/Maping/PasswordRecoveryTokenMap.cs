using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class PasswordRecoveryTokenMap : ClassMap<PasswordRecoveryToken>
    {
        public PasswordRecoveryTokenMap()
        {
            Table("PasswordRecoveryTokens");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.CreationDateTime);
            Map(x => x.ExpirationDateTime);
            Map(x => x.State);
            Map(x => x.AppId);
            Map(x => x.UserId);
        }
	}
}
