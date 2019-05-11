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
                                IsReaded = dbContext.EmployeeDocuments.Any(ed => ed.Document.Id == dbDocument.Id && ed.Employee.Id == employeeId) ? 
                                            !dbContext.EmployeeDocuments.Where(ed => ed.Document.Id == dbDocument.Id && ed.Employee.Id == employeeId).Select(ed => ed.NotReaded).FirstOrDefault() : false,
                                NeedResign = dbDocument.NeedResign,
                                IsApprovalParticipant = dbContext.InternalDocflowPackages
                                .Where(p => p.Sender.Client.Id == employeeId)
                                .Any(p =>
                                        // пакет согласования
                                        //p.ApprovalPackage != null
                                        //&& p.ApprovalPackage.DocumentApprovals.Any(da =>
                                        //    da.DocumentId != null && da.DocumentId == dbDocument.Id ||
                                        //    da.DraftId != null && da.DraftId == dbDocument.Id)
                                        //// пакет исходящих документов на подпись
                                        /*||*/ 
                                            (from opfs in dbContext.OutcomingPackageForSignings
                                             where opfs.Id == p.Id &&
                                                    dbContext.Documents.Any(d => d.Group.Id == opfs.DocumentsGroup.Id)
                                             select opfs.Id
                                            ).Any()
                                        //||
                                            //(from opfs in dbContext.OutcomingPackageForSignings
                                            // where opfs.Id == p.Id &&
                                            //        dbContext.Drafts.Any(d => d.DraftGroup.Id == opfs.DraftsGroup.Id)
                                            // select opfs.Id
                                            //).Any()
                                        // пакет входящего документа на подпись
                                        || dbContext.IncomingPackagesForSignings.Any(ipfs => 
                                            ipfs.Document.Id == dbDocument.Id &&
                                            ipfs.Id == p.Id))
                            })
                            .Skip((page - 1) * 10)
                            .Take(10)
                            .ToArray();

            return result;
        }
    }
}