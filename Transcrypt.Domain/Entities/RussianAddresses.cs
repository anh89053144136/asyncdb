using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class RussianAddresses
    {
        public Guid Id { get; set; }
        public string PostIndex { get; set; }
        public Guid RegionId { get; set; }

        //[Association(ThisKey = "RegionId", OtherKey = "Id")]
        public Region Region { get; set; }

        public string Area { get; set; }
        public string City { get; set; }
        public string Settlement { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Structure { get; set; }
        public string Apartment { get; set; }
    }
}
