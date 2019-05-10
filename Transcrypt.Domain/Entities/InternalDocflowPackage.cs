using System;

namespace Transcrypt.Domain.Entities
{
    public class InternalDocflowPackage
    {
        public virtual Guid Id { get; set; }
        public virtual Guid SenderId { get; set; }
        public virtual Guid? ReceiverId { get; set; }
        public virtual Guid? ReceiverDepartmentId { get; set; }
        public virtual int ReceiverType { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual string CreationComment { get; set; }
        public virtual DateTime? ProcessingDate { get; set; }
        public virtual string ProcessingComment { get; set; }
        public virtual int State { get; set; }
        public virtual int Type { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        /// <summary>
		/// Пакет согласования
		/// </summary>
		//[Association(ThisKey = "Id", OtherKey = "Id", CanBeNull = true)]
        public virtual ApprovalPackage ApprovalPackage { get; set; }

        /// <summary>
        /// Пакет исходящих документов на подписание
        /// </summary>
        //[Association(ThisKey = "Id", OtherKey = "Id", CanBeNull = true)]
        public virtual OutcomingPackagesForSigning OutcomingPackageForSigning { get; set; }

        /// <summary>
        /// Пакет входящего документа на подписание
        /// </summary>
        //[Association(ThisKey = "Id", OtherKey = "Id", CanBeNull = true)]
        public virtual IncomingPackagesForSigning IncomingPackageForSigning { get; set; }

        /// <summary>
        /// Инициатор
        /// </summary>
        //[Association(ThisKey = "SenderId", OtherKey = "Id", CanBeNull = true)]
        public virtual Employee Sender { set; get; }
    }
}