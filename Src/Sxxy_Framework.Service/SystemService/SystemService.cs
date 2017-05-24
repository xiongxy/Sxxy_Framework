using Sxxy_Framework.DataAccess;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;
using Sxxy_Framework.Repository;
using Sxxy_Framework.Repository.IEntityRepository;
using Sxxy_Framework.Service.ISystemService;

namespace Sxxy_Framework.Service.SystemService
{
    public class SystemRoleService : ISystemRoleService
    {
        private readonly ISystemRoleRepository _repository;
        public SystemRoleService(ISystemRoleRepository systemRoleRepository)
        {
            _repository = systemRoleRepository;
        }
    }
}
