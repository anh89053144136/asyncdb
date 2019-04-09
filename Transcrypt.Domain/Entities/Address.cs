using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class Address
    {
        public Guid Id { get; set; }

        public int TypeId { get; set; }
    }
}