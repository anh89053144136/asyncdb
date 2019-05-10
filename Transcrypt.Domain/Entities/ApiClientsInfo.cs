using System;

namespace Transcrypt.Domain.Entities
{
    public class ApiClientsInfo
    {
        public virtual Guid ClientId { get; set; }

        public virtual DateTime RegistrationDateTime { get; set; }

        public virtual string Settings { get; set; }

        public virtual string Description { get; set; }

        public virtual Guid ProgramInfoId { get; set; }
        
        //[Association(ThisKey = "ProgramInfoId", OtherKey = "Id")]
        public virtual ProgramInfo ProgramInfo { get; set; }
    }
}
