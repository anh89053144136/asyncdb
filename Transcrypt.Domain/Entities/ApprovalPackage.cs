using System;
using System.Collections.Generic;

namespace Transcrypt.Domain.Entities
{
    public class ApprovalPackage
    {
        /// <summary>
		/// Идентификатор
		/// </summary>
		public virtual Guid Id { get; set; }

        /// <summary>
        /// Пакет внутреннего документооборота
        /// </summary>
        //[Association(ThisKey = "Id", OtherKey = "Id", CanBeNull = false)]
        public virtual InternalDocflowPackage InternalPackageDc { get; set; }

        /// <summary>
        /// Согласования документов
        /// </summary>
        //[Association(ThisKey = "Id", OtherKey = "ApprovalPackageId")]
        public virtual IEnumerable<DocumentApproval> DocumentApprovals { get; set; }
    }
}
