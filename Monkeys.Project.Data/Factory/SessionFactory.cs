using Monkeys.Project.DTO;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monkeys.Project.Data.Factory
{
    public static class SessionFactory
    {
        // make sure this should be generated only once.
        public static ISessionFactory _sessionFactory = null;

        public static ISessionFactory GetSessionFactory()
        {
            try
            {
                if (_sessionFactory == null)
                {
                    var nhCnfig = new NHibernate.Cfg.Configuration();
                    var xxxx = AppDomain.CurrentDomain.BaseDirectory;
                    nhCnfig.Configure(@"E:/Projects/_other/Monkeys.Project/Monkeys.Project.Data/hibernate.cfg.xml");

                    //nhCnfig.DataBaseIntegration(delegate (NHibernate.Cfg.Loquacious.IDbIntegrationConfigurationProperties abc)
                    //{
                    //    abc.ConnectionString = "Database=monkeys_project;Data Source=localhost;Port=3306;User Id=root;Password=P@ssw0rd";
                    //    abc.Dialect<NHibernate.Dialect.MySQL55Dialect>();
                    //    abc.Driver<NHibernate.Driver.MySqlDataDriver>();
                    //    abc.Timeout = 60;
                    //});

                    //one of your model in our case we just have one model
                    nhCnfig.AddAssembly(typeof(MasterUser).Assembly);

                    nhCnfig.AddFile("E:/Projects/_other/Monkeys.Project/Monkeys.Project.Data/Mapping/MasterUser.hbm.xml");

                    //nhCnfig.CurrentSessionContext<WebSessionContext>();
                    _sessionFactory = nhCnfig.BuildSessionFactory();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _sessionFactory;
        }

        public static ISession GetCurrentSession()
        {
            if (!CurrentSessionContext.HasBind(GetSessionFactory()))
                CurrentSessionContext.Bind(GetSessionFactory().OpenSession());

            return GetSessionFactory().GetCurrentSession();
        }

        public static void DisposeCurrentSession()
        {
            ISession currentSession = CurrentSessionContext.Unbind(GetSessionFactory());

            currentSession.Close();
            currentSession.Dispose();
        }
    }
}
