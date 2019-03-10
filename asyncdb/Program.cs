using System;
using System.IO;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
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
            Console.WriteLine("Hello World!");

            _sessionFactory = Fluently.Configure()
             .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Server=.;Database=asyncdb;Trusted_Connection=True;"))
             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernate.Cfg.Mappings>())
             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<asyncdb.Program>())
             .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
             .BuildSessionFactory();

            ISession session = _sessionFactory.OpenSession();

            DBFile newFile = new DBFile();
            newFile.Name = "first file";
            newFile.Content = File.ReadAllBytes("C:\\Users\\anh\\Desktop\\UXFSvywADvc.jpg");

            session.SaveAsync(newFile);
            session.FlushAsync();

            _sessionFactory.Close();
        }
    }
}
