using System;

namespace Transcrypt.Domain.Entities
{
    public class ServicePackage
    {
        public Guid Id { get; set; }

        public Guid ClientId { get; set; }

        public int SendingsLimit { get; set; }

        public int TimeLimit { get; set; }

        public int TimeLimitType { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string Description { get; set; }

        public DateTime? ActivationDate { get; set; }

        public int SentCount { get; set; }

        public int State { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? CountExpiredDate { get; set; }

        public int MessageUnitType { get; set; }

        public int Type { get; set; }
    }
}