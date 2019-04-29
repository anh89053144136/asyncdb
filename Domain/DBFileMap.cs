using FluentNHibernate.Mapping;

namespace asyncdb
{
    public class DBFileMap : ClassMap<DBFile>
    {
        public DBFileMap()
        {
            Table("DBFiles");

            Id(x => x.Id).GeneratedBy.Guid();

            Map(x => x.Name);
            Map(x => x.CreatedDate).Generated.Insert();
            Map(x => x.Content).Length(int.MaxValue);
        }
    }
}
