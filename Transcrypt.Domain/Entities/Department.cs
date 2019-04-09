using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class Department
    {
        public Guid Id { get; set; }

        public Guid ClientId { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public Guid? ParentId { get; set; }

        public string Kpp { get; set; }

        // TODO денормализовать адрес
        public Guid? AddressId { get; set; }
        
        //[Association(ThisKey = "ClientId", OtherKey = "Id")]
        public Client Client { get; set; }
        
        //[Association(ThisKey = "ParentId", OtherKey = "Id", CanBeNull = true)]
        public Department Parent { get; set; }
    }
}
