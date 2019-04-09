using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class Country
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
    }
}