using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class ForeignAddresses
    {
        public Guid Guid { get; set; }
        public string Text { get; set; }
        public Guid CountryId { get; set; }

        //[Association(ThisKey = "CountryId", OtherKey = "Id")]
        public Country Country { get; set; }
    }
}