using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class FileContentMap : ClassMap<FileContent>
    {
        public FileContentMap()
        {
            Table("FileContents");

            Id(x => x.Id);

            Map(x => x.Content);
            Map(x => x.DataStorageId);
        }
    }
}
