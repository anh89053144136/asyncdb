using System;

namespace Transcrypt.Domain.Entities
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