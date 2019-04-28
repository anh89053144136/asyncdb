﻿using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class EmailTemplateMap : ClassMap<EmailTemplate>
    {
        public EmailTemplateMap()
        {
            Table("EmailTemplates");

            Map(x => x.EmailType);
            Map(x => x.Message);
            Map(x => x.Subject);
        }
	}
}
