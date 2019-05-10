using System;
using FluentNHibernate.Mapping;

namespace Transcrypt.Domain.Entities
{
    public class FileMap : ClassMap<File>
    {
        public FileMap()
        {
            Table("Files");

            Id(x => x.Id);

            Map(x => x.FileName);
            Map(x => x.Size);
            Map(x => x.Code);
            Map(x => x.IsEncrypted);
            Map(x => x.NeedCheckFlc);
            Map(x => x.NeedCheckSign);
            Map(x => x.CheckState);

            References(x => x.Transaction).Column("TransactionId");
            //References(x => x.CeFileContentrt).Column("Id");
        }
    }
}
