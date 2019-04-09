using System;
using System.Collections.Generic;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
	public class DocumentGroup
	{
		public Guid Id { get; set; }

		//[Association(ThisKey = "SenderId", OtherKey = "Id")]
		public Client Sender { get; set; }

		//[Association(ThisKey = "ReceiverId", OtherKey = "Id")]
		public Client Receiver { get; set; }

		public DocumentGroupState State { get; set; }

		public DateTime CreateDateTime { get; set; }

		public DateTime UpdateDateTime { get; set; }

		public DateTime? ReceivedDateTime { get; set; }

		public DateTime? SendDateTime { get; set; }

		//[Association(ThisKey = "Id", OtherKey = "GroupId", CanBeNull = false)]
		public IEnumerable<Document> Documents { get; set; }

		public Guid SenderId { get; set; }

		public Guid ReceiverId { get; set; }
	}
}
