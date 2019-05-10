using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Transcrypt.Domain;
using Transcrypt.Domain.Entities;

namespace Transcrypt.Incoming.Controllers
{
    [Route("api/[controller]")]
    public class DocsController : ControllerBase
    {
        private DBContext dbContext = new DBContext();
        static DocsController()
        {
        }

        [HttpGet("[action]")]
        public virtual IEnumerable Get(int page)
        {
            Guid employeeId = new Guid("18F9F5E3-3033-4E42-B162-DE61CCB4E628"); // Тестовый Абонент Иванович  
            Guid clientId = new Guid("43B70443-D84E-4BDA-8042-27B6C1CAC17D"); // точка зрения
//documentsQuery
            var result =   (from dbDocument in dbContext.Documents
                            //where groupIds.Contains(dbDocument.GroupId)
                            //join empDoc in db.EmployeeDocuments on new { documentId = dbDocument.Id, employeeId } equals new
                            //{
                            //    documentId = empDoc.DocumentId,
                            //    employeeId = empDoc.EmployeeId
                            //} into empLj
                            //from empDoc in empLj.DefaultIfEmpty()
                            
                            //join dbSender in db.Clients on dbDocument.SenderId equals dbSender.Id
                            //join op in db.Operators on dbSender.OperatorId equals op.Id
                            select new 
                            {
                                dbDocument.Id,
                                GroupId = dbDocument.Group.Id,
                                ReceivedDate = dbDocument.ReceivedDateTime,
                                SentDate = dbDocument.SendDateTime,
                                dbDocument.Title,
                                Type = new
                                {
                                    Code = dbDocument.Code,
                                    Name = dbDocument.TypeClass.ShortName
                                },
                                Direction = "DocumentDirection.Incoming",
                                State = dbDocument.ReceiverState,
                                Contractor = new
                                {
                                    Id = dbDocument.Sender.Id,
                                    DocflowUserId = dbDocument.Sender.DocflowUserId,
                                    Name = dbDocument.Sender.Name,
                                    Inn = dbDocument.Sender.Inn,
                                    Kpp = dbContext.ClientJurs.Where(o => o.Id == dbDocument.Sender.Id).Select(o => o.Kpp).FirstOrDefault(),
                                    IsRoaming = dbContext.Operators.Where(o => o.Id == dbDocument.Sender.OperatorId).Select(o => o.Type).FirstOrDefault() == 1 // OperatorType.External
                                },
                                Department = dbDocument.ReceiverDepartment == null
                                    ? null
                                    : new 
                                    {
                                        Id = dbDocument.ReceiverDepartment.Id,
                                        dbDocument.ReceiverDepartment.Name
                                    },
                                //IsReaded = empDoc != null ? !empDoc.NotReaded : false,
                                NeedResign = dbDocument.NeedResign,
                                //IsApprovalParticipant = dbContext.InternalDocflowPackages
                                //.Where(p => p.Sender.ClientId == employeeId)
                                //.Any(p =>
                                //        // пакет согласования
                                //        p.ApprovalPackage != null
                                //        && p.ApprovalPackage.DocumentApprovals.Any(da =>
                                //            da.DocumentId != null && da.DocumentId == dbDocument.Id ||
                                //            da.DraftId != null && da.DraftId == dbDocument.Id)
                                //        // пакет исходящих документов на подпись
                                //        || (p.OutcomingPackageForSigning != null
                                //            && p.OutcomingPackageForSigning.DocumentsGroupId != null
                                //            && p.OutcomingPackageForSigning.DocumentsGroup.Documents.Any(doc => doc.Id == dbDocument.Id)
                                //            || p.OutcomingPackageForSigning.DraftsGroupId != null
                                //            && p.OutcomingPackageForSigning.DraftsGroup.Drafts.Any(draft => draft.Id == dbDocument.Id))
                                //        // пакет входящего документа на подпись
                                //        || p.IncomingPackageForSigning != null
                                //        && p.IncomingPackageForSigning.DocumentId == dbDocument.Id)
                            })
                            .Skip((page - 1) * 20)
                            .Take(20)
                            .ToArray();

            return result;
        }
    }
}