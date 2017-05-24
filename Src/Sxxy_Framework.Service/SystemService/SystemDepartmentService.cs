using Sxxy_Framework.DataAccess;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;
using Sxxy_Framework.Repository;
using Sxxy_Framework.Repository.IEntityRepository;
using Sxxy_Framework.Service.ISystemService;

namespace Sxxy_Framework.Service.SystemService
{
    public class SystemDepartmentService :ISystemDepartmentService
    {
        private readonly ISystemDepartmentRepository _repository;
        public SystemDepartmentService(ISystemDepartmentRepository systemDepartmentRepository)
        {
            _repository = systemDepartmentRepository;
        }
    }
}
