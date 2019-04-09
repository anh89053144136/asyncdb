using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class ApiClientsInfo
    {
        public Guid ClientId { get; set; }

        public DateTime RegistrationDateTime { get; set; }

        public string Settings { get; set; }

        public string Description { get; set; }

        public Guid ProgramInfoId { get; set; }
        
        //[Association(ThisKey = "ProgramInfoId", OtherKey = "Id")]
        public ProgramInfo ProgramInfo { get; set; }
    }
}
