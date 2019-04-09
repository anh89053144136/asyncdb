using System;
using System.Collections.Generic;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class ApprovalPackage
    {
        /// <summary>
		/// Идентификатор
		/// </summary>
		public Guid Id { get; set; }

        /// <summary>
        /// Пакет внутреннего документооборота
        /// </summary>
        //[Association(ThisKey = "Id", OtherKey = "Id", CanBeNull = false)]
        public InternalDocflowPackage InternalPackageDc { get; set; }

        /// <summary>
        /// Согласования документов
        /// </summary>
        //[Association(ThisKey = "Id", OtherKey = "ApprovalPackageId")]
        public IEnumerable<DocumentApproval> DocumentApprovals { get; set; }
    }
}
