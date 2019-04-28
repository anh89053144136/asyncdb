using System;

namespace Transcrypt.Domain.Entities
{
    public class ClientNat
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Inn { get; set; }
        public string Ogrnip { get; set; }
        public string FullName { get; set; }
    }
}