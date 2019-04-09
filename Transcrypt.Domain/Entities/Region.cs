using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class Region
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }
    }
}