using System;
using System.Collections.Generic;

namespace Transcrypt.Domain.Entities
{
	public class DocumentGroup
	{
		public virtual Guid Id { get; set; }

		//[Association(ThisKey = "SenderId", OtherKey = "Id")]
		public virtual Client Sender { get; set; }

		//[Association(ThisKey = "ReceiverId", OtherKey = "Id")]
		public virtual Client Receiver { get; set; }

		public virtual DocumentGroupState State { get; set; }

		public virtual DateTime CreateDateTime { get; set; }

		public virtual DateTime UpdateDateTime { get; set; }

		public virtual DateTime? ReceivedDateTime { get; set; }

		public virtual DateTime? SendDateTime { get; set; }

		//[Association(ThisKey = "Id", OtherKey = "GroupId", CanBeNull = false)]
		public virtual IEnumerable<Document> Documents { get; set; }

		public virtual Guid SenderId { get; set; }

		public virtual Guid ReceiverId { get; set; }
	}
}
