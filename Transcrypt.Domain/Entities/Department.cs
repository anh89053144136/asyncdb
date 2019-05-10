using System;

namespace Transcrypt.Domain.Entities
{
    public class Department
    {
        public virtual Guid Id { get; set; }

        public virtual Guid ClientId { get; set; }

        public virtual string Name { get; set; }

        public virtual string ShortName { get; set; }

        public virtual Guid? ParentId { get; set; }

        public virtual string Kpp { get; set; }

        // TODO денормализовать адрес
        public virtual Guid? AddressId { get; set; }
        
        //[Association(ThisKey = "ClientId", OtherKey = "Id")]
        public virtual Client Client { get; set; }
        
        //[Association(ThisKey = "ParentId", OtherKey = "Id", CanBeNull = true)]
        public virtual Department Parent { get; set; }
    }
}
