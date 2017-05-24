using Sxxy_Framework.DataAccess;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;
using Sxxy_Framework.Repository;
using Sxxy_Framework.Repository.IEntityRepository;
using Sxxy_Framework.Service.ISystemService;

namespace Sxxy_Framework.Service.SystemService
{
    class SystemMenuService : ISystemMenuService
    {
        private readonly ISystemMenuRepository _repository;
        public SystemMenuService(ISystemMenuRepository systemMenuRepository)
        {
            _repository = systemMenuRepository;
        }
    }
}
