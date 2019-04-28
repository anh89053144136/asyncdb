using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using NHibernate;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Transcrypt.Domain;

namespace Transcrypt.Incoming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocsController : ControllerBase
    {
        private static ISessionFactory _sessionFactory;

        static DocsController()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("Storage");

            _sessionFactory = Fluently.Configure()
             .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernate.Cfg.Mappings>())
             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DBContext>())
             .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
             .BuildSessionFactory();
        }
    }
}