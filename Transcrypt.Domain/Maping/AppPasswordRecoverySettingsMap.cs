﻿using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class AppPasswordRecoverySettingsMap : ClassMap<AppPasswordRecoverySettings>
    {
        public AppPasswordRecoverySettingsMap()
        {
            Table("AppPasswordRecoverySettingss");

            Id(x => x.AppId).GeneratedBy.Guid();

            Map(x => x.Host);
            Map(x => x.RecoveryPage);
        }
	}
}
