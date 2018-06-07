using Monkeys.Project.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monkeys.Project.Service
{
    public interface IMasterUserService
    {
        IList<MasterUser> FindAll();
    }
}
