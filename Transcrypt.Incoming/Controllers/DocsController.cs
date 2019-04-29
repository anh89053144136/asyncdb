using System;
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
        public IEnumerable<Document> Get()
        {
            var result = dbContext.Documents.Take(20);

            return result;
        }
    }
}