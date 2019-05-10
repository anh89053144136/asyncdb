using System;

namespace Transcrypt.Domain.Entities
{
    public class ForeignAddresses
    {
        public virtual Guid Guid { get; set; }
        public virtual string Text { get; set; }
        public virtual Guid CountryId { get; set; }

        //[Association(ThisKey = "CountryId", OtherKey = "Id")]
        public virtual Country Country { get; set; }
    }
}