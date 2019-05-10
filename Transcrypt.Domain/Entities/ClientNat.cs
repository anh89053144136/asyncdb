using System;

namespace Transcrypt.Domain.Entities
{
    public class ClientNat
    {
        public virtual Guid Id { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string Inn { get; set; }
        public virtual string Ogrnip { get; set; }
        public virtual string FullName { get; set; }
    }
}