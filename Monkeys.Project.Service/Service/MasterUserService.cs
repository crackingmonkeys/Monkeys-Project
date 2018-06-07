using Monkeys.Project.Data.IRepository;
using Monkeys.Project.Data.Repository;
using Monkeys.Project.DTO;
using System.Collections.Generic;

namespace Monkeys.Project.Service
{
    public class MasterUserService : BaseService, IMasterUserService
    {
        private IMasterUserRepository _masterUserRepository;

        public MasterUserService()
        {
            _masterUserRepository = new MasterUserRepository();
        }

        public IList<MasterUser> FindAll()
        {
            return _masterUserRepository.FindAll();
        }
    }
}
