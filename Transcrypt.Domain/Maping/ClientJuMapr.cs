using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
	public class ClientJurMap : ClassMap<ClientJur>
    {
        public ClientJurMap()
        {
            Table("ClientJurs");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.FullName);
            Map(x => x.ShortName);
            Map(x => x.Inn);
            Map(x => x.Kpp);
            Map(x => x.Ogrn);
        }
	}
}
