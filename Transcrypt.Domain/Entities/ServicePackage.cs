using System;

namespace Transcrypt.Domain.Entities
{
    public class ServicePackage
    {
        public virtual Guid Id { get; set; }

        public virtual Guid ClientId { get; set; }

        public virtual int SendingsLimit { get; set; }

        public virtual int TimeLimit { get; set; }

        public virtual int TimeLimitType { get; set; }

        public virtual DateTime? ExpirationDate { get; set; }

        public virtual string Description { get; set; }

        public virtual DateTime? ActivationDate { get; set; }

        public virtual int SentCount { get; set; }

        public virtual int State { get; set; }

        public virtual DateTime CreateDate { get; set; }

        public virtual DateTime? CountExpiredDate { get; set; }

        public virtual int MessageUnitType { get; set; }

        public virtual int Type { get; set; }
    }
}