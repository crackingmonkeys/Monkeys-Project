using Monkeys.Project.Data.Factory;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monkeys.Project.Data.Repository
{
    public class BaseRepository
    {
        //ISessionFactory sf = null;

        public BaseRepository()
        {
            //sf = SessionFactory.GetSessionFactory();
        }

        //public ISession GetCurrentSession()
        //{
        //    return sf.GetCurrentSession();
        //}

        #region Dispose

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        // Dispose managed resources
        //    }

        //    // Free native resources
        //}

        //public void Dispose()
        //{
        //    Dispose(true);

        //    GC.SuppressFinalize(this);
        //}

        //// Disposable types implement a finalizer.
        //~BaseRepository()
        //{
        //    Dispose(false);
        //} 

        #endregion
    }
}
