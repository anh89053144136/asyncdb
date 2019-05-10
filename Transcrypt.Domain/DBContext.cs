using System;
using Transcrypt.Domain.Entities;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using NHibernate;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;

namespace Transcrypt.Domain
{
    public class DBContext
    {
        #region Settings 
        private static ISessionFactory sessionFactory;

        static DBContext()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("Storage");

            sessionFactory = Fluently.Configure()
             .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernate.Cfg.Mappings>())
             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DBContext>())
             //.ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
             .BuildSessionFactory();
        }

        #endregion

        private ISession session;

        public DBContext()
        {
            session = sessionFactory.OpenSession();
        }

        #region Tables 

        public IQueryable<Document> Documents
        {
            get
            {
                return session.Query<Document>();
            }
        }

        public IQueryable<EmployeeDocument> EmployeeDocuments {
            get
            {
                return session.Query<EmployeeDocument>();
            }
        }

        public IQueryable<ClientJur> ClientJurs
        {
            get
            {
                return session.Query<ClientJur>();
            }
        }

        public IQueryable<InternalDocflowPackage> InternalDocflowPackages
        {
            get
            {
                return session.Query<InternalDocflowPackage>();
            }
        }

        public IQueryable<Operator> Operators
        {
            get
            {
                return session.Query<Operator>();
            }
        }

        #endregion
    }
}
/*
 * var documentsQuery = db.Documents
						.LoadWith(d => d.Sender)
						.LoadWith(d => d.Receiver)
						.LoadWith(d => d.SenderDepartment)
						.LoadWith(d => d.ReceiverDepartment)
						.LoadWith(d => d.TypeClass)
						.Where(d => d.GroupId == documentGroupId.Value)
						.Where(d => d.SenderId == employee.ClientId || d.ReceiverId == employee.ClientId);

from dbDocument in documentsQuery	
join empDoc in db.EmployeeDocuments on new {documentId = dbDocument.Id, employeeId = employeeId.Value} equals new
{
	documentId = empDoc.DocumentId,
	employeeId = empDoc.EmployeeId
} into empLj
from empDoc in empLj.DefaultIfEmpty()
join o in db.GetTable<DbClientJur>() on dbDocument.SenderId equals o.Id into so
from senderOrganization in so.DefaultIfEmpty()
join o in db.GetTable<DbClientJur>() on dbDocument.ReceiverId equals o.Id into ro
from receiverOrganization in ro.DefaultIfEmpty()
select new Document
{
	Id = new DocumentId(dbDocument.Id),
	GroupId = new DocumentGroupId(dbDocument.GroupId),
	ReceivedDate = dbDocument.ReceivedDateTime,
	SentDate = dbDocument.SentDateTime,
	Title = dbDocument.Title,
	Type = new DocumentType
	{
		Code = dbDocument.Code,
		Name = dbDocument.TypeClass.ShortName
	},
	Direction = dbDocument.SenderId == employee.ClientId
		? DocumentDirection.Outcoming
		: DocumentDirection.Incoming,
	State = (DocumentState) (dbDocument.SenderId == employee.ClientId
		// Исходящий
		? dbDocument.SenderState
		// Входящий
		: dbDocument.ReceiverState),
	Contractor = dbDocument.SenderId == employee.ClientId
		// Исходящий. Контрагент - получатель
		? new Contractor
		{
			Id = new ClientId(dbDocument.ReceiverId),
			DocflowUserId = dbDocument.Receiver.DocflowUserId,
			Name = dbDocument.Receiver.Name,
			Inn = dbDocument.Receiver.Inn,
			Kpp = receiverOrganization == null ? string.Empty : receiverOrganization.Kpp
		}
		// Входящий. Контрагент - отправитель
		: new Contractor
		{
			Id = new ClientId(dbDocument.SenderId),
			DocflowUserId = dbDocument.Sender.DocflowUserId,
			Name = dbDocument.Sender.Name,
			Inn = dbDocument.Sender.Inn,
			Kpp = senderOrganization == null ? string.Empty : senderOrganization.Kpp
		},
	Department = dbDocument.SenderId == employee.ClientId
		// Исходящий. Нужно подразделение отправителя
		? (dbDocument.SenderDepartmentId == null
			? null
			: new Department
			{
				Id = new DepartmentId(dbDocument.SenderDepartmentId.Value),
				Name = dbDocument.SenderDepartment.Name
			})
		// Входящий. Нужно подразделение получателя
		: (dbDocument.ReceiverDepartmentId == null
			? null
			: new Department
			{
				Id = new DepartmentId(dbDocument.ReceiverDepartmentId.Value),
				Name = dbDocument.ReceiverDepartment.Name
			}),
	NeedResign = dbDocument.NeedResign,
	IsReaded = empDoc != null && !empDoc.NotReaded,
	IsDeleted = dbDocument.SenderId == employee.ClientId ?
		dbDocument.IsSenderDeleted : dbDocument.IsReceiverDeleted,
    IsApprovalParticipant = db.InternalDocflowPackages
    .Where(p => p.Sender.ClientId == employee.ClientId)
    .Any(p =>
        // пакет согласования
        p.ApprovalPackage != null
        && p.ApprovalPackage.DocumentApprovals.Any(da =>
            da.DocumentId != null && da.DocumentId == dbDocument.Id ||
            da.DraftId != null && da.DraftId == dbDocument.Id)
        // пакет исходящих документов на подпись
        || (p.OutcomingPackageForSigning != null
            && p.OutcomingPackageForSigning.DocumentsGroupId != null
            && p.OutcomingPackageForSigning.DocumentsGroup.Documents.Any(doc => doc.Id == dbDocument.Id)
            || p.OutcomingPackageForSigning.DraftsGroupId != null
            && p.OutcomingPackageForSigning.DraftsGroup.Drafts.Any(draft => draft.Id == dbDocument.Id))
        // пакет входящего документа на подпись
        || p.IncomingPackageForSigning != null
        && p.IncomingPackageForSigning.DocumentId == dbDocument.Id)
})
     */
