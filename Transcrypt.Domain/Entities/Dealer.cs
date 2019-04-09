using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class Dealer
    {
        public Guid Id { get; set; }

        public Guid OperatorId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int State { get; set; }
    }
}
