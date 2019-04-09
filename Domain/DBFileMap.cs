using FluentNHibernate.Mapping;

namespace asyncdb
{
    public class FileMap : ClassMap<DBFile>
    {
        public DBFileMap()
        {
            Table("DBFiles");

            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.Name);
            Map(x => x.CreatedDate).Generated.Insert();
            Map(x => x.Content).Length(int.MaxValue);
        }
    }
}
