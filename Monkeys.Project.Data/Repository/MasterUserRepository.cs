using Monkeys.Project.Data.Factory;
using Monkeys.Project.Data.IRepository;
using Monkeys.Project.DTO;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monkeys.Project.Data.Repository
{
    public class MasterUserRepository : BaseRepository, IMasterUserRepository
    {
        public MasterUserRepository()
        {

        }

        public IList<MasterUser> FindAll()
        {
            IList<MasterUser> result = new List<MasterUser>();
            using (var session = SessionFactory.GetCurrentSession())
            {
                MasterUser x = new MasterUser();
                x.Username = "xxxx";
                x.Password = "xxxx";
                x.Userstatus = 2;
                session.Save(x);
                result = session.QueryOver<MasterUser>().List();
            }

            return result;
        }
    }
}
