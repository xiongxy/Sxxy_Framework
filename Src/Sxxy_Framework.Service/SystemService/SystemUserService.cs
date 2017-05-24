using AutoMapper;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;
using Sxxy_Framework.Repository.IEntityRepository;
using Sxxy_Framework.Service.Dtos.SystemDto;
using Sxxy_Framework.Service.ISystemService;

namespace Sxxy_Framework.Service.SystemService
{
    public class SystemUserService : ISystemUserService
    {
        //用户管理仓储接口
        private readonly ISystemUserRepository _repository;

        /// <summary>
        /// 构造函数 实现依赖注入
        /// </summary>
        /// <param name="systemUserRepository">仓储对象</param>
        public SystemUserService(ISystemUserRepository systemUserRepository)
        {
            _repository = systemUserRepository;
        }

        public SystemUserDto CheckUser(string userName, string password)
        {
            return Mapper.Map<SystemUserDto>(_repository.FirstOrDefault(x => x.UserName == userName && x.Password == password));
        }

    }
}
