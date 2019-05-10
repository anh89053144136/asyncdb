using System;

namespace Transcrypt.Domain.Entities
{
    public class OutcomingPackagesForSigning
    {
        public virtual Guid Id { get; set; }
        public virtual Guid? DocumentsGroupId { get; set; }

        public virtual Guid? DraftsGroupId { get; set; }

        /// <summary>
		/// ������ ����������
		/// </summary>
		//[Association(ThisKey = "DraftsGroupId", OtherKey = "Id", CanBeNull = true)]
        public virtual DraftGroup DraftsGroup { get; set; }

        /// <summary>
        /// ������ ����������
        /// </summary>
        //[Association(ThisKey = "DocumentsGroupId", OtherKey = "Id", CanBeNull = true)]
        public virtual DocumentGroup DocumentsGroup { get; set; }
    }
}