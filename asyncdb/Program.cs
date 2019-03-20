using System;
using System.IO;
using System.Linq;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;

namespace asyncdb
{
    class Program
    {
        private static ISessionFactory _sessionFactory;

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("Storage");
            Console.WriteLine(connectionString);

            _sessionFactory = Fluently.Configure()
             .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernate.Cfg.Mappings>())
             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<asyncdb.Program>())
             .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
             .BuildSessionFactory();

            ISession session = _sessionFactory.OpenSession();

            //DBFile newFile = new DBFile();
            //newFile.Name = "first file";
            //newFile.Content = File.ReadAllBytes("C:\\Users\\anh\\Desktop\\UXFSvywADvc.jpg");
            //session.SaveAsync(newFile);
            //session.FlushAsync();

            DBFile file = session.Query<DBFile>().FirstOrDefault();
            _sessionFactory.Close();

            Console.WriteLine(file.Name);
            Console.Read();
        }
    }
}
