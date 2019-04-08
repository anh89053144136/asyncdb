using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using NHibernate;
using System.IO;
using Microsoft.Extensions.Configuration;
using asyncdb;
using System.Linq;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static ISessionFactory _sessionFactory;

        static ValuesController()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("Storage");

            _sessionFactory = Fluently.Configure()
             .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernate.Cfg.Mappings>())
             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ValuesController>())
             .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
             .BuildSessionFactory();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<DBFile>> Get()
        {
            ISession session = _sessionFactory.OpenSession();

            var result = session.Query<DBFile>().ToArray();
            _sessionFactory.Close();

            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //DBFile newFile = new DBFile();
            //newFile.Name = "first file";
            //newFile.Content = File.ReadAllBytes("C:\\Users\\anh\\Desktop\\UXFSvywADvc.jpg");
            //session.SaveAsync(newFile);
            //session.FlushAsync();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
