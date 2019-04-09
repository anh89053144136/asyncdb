using System;

namespace Taxnet.Transcrypt.Repositories.Linq2Db.Model
{
    public class InternalDocflowPackage
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid? ReceiverId { get; set; }
        public Guid? ReceiverDepartmentId { get; set; }
        public int ReceiverType { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationComment { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public string ProcessingComment { get; set; }
        public int State { get; set; }
        public int Type { get; set; }
        public DateTime UpdateDate { get; set; }
        /// <summary>
		/// ����� ������������
		/// </summary>
		//[Association(ThisKey = "Id", OtherKey = "Id", CanBeNull = true)]
        public ApprovalPackage ApprovalPackage { get; set; }

        /// <summary>
        /// ����� ��������� ���������� �� ����������
        /// </summary>
        //[Association(ThisKey = "Id", OtherKey = "Id", CanBeNull = true)]
        public OutcomingPackagesForSigning OutcomingPackageForSigning { get; set; }

        /// <summary>
        /// ����� ��������� ��������� �� ����������
        /// </summary>
        //[Association(ThisKey = "Id", OtherKey = "Id", CanBeNull = true)]
        public IncomingPackagesForSigning IncomingPackageForSigning { get; set; }

        /// <summary>
        /// ���������
        /// </summary>
        //[Association(ThisKey = "SenderId", OtherKey = "Id", CanBeNull = true)]
        public Employee Sender { set; get; }
    }
}