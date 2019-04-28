using System;

namespace Transcrypt.Domain.Entities
{
    public class OutcomingPackagesForSigning
    {
        public Guid Id { get; set; }
        public Guid? DocumentsGroupId { get; set; }

        public Guid? DraftsGroupId { get; set; }

        /// <summary>
		/// Группа черновиков
		/// </summary>
		//[Association(ThisKey = "DraftsGroupId", OtherKey = "Id", CanBeNull = true)]
        public DraftGroup DraftsGroup { get; set; }

        /// <summary>
        /// Группа документов
        /// </summary>
        //[Association(ThisKey = "DocumentsGroupId", OtherKey = "Id", CanBeNull = true)]
        public DocumentGroup DocumentsGroup { get; set; }
    }
}