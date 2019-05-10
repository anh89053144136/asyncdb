using System;

namespace Transcrypt.Domain.Entities
{
    public class RussianAddresses
    {
        public virtual Guid Id { get; set; }
        public virtual string PostIndex { get; set; }
        public virtual Guid RegionId { get; set; }

        //[Association(ThisKey = "RegionId", OtherKey = "Id")]
        public virtual Region Region { get; set; }

        public virtual string Area { get; set; }
        public virtual string City { get; set; }
        public virtual string Settlement { get; set; }
        public virtual string Street { get; set; }
        public virtual string House { get; set; }
        public virtual string Structure { get; set; }
        public virtual string Apartment { get; set; }
    }
}
