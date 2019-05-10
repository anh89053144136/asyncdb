using System;

namespace Transcrypt.Domain.Entities
{
    public class OutcomingPackagesForSigning
    {
        public virtual Guid Id { get; set; }
        public virtual Guid? DocumentsGroupId { get; set; }

        public virtual Guid? DraftsGroupId { get; set; }

        /// <summary>
		/// Группа черновиков
		/// </summary>
		//[Association(ThisKey = "DraftsGroupId", OtherKey = "Id", CanBeNull = true)]
        public virtual DraftGroup DraftsGroup { get; set; }

        /// <summary>
        /// Группа документов
        /// </summary>
        //[Association(ThisKey = "DocumentsGroupId", OtherKey = "Id", CanBeNull = true)]
        public virtual DocumentGroup DocumentsGroup { get; set; }
    }
}