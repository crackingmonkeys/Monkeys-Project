using Monkeys.Project.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monkeys.Project.Data.IRepository
{
    public interface IMasterUserRepository
    {
        IList<MasterUser> FindAll();
    }
}
