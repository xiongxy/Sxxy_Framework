using System;
using System.Collections.Generic;
using System.Text;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;
using Sxxy_Framework.Repository.IEntityRepository;
using Sxxy_Framework.Service.IService;

namespace Sxxy_Framework.Service.Service
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

        public SystemUser CheckUser(string userName, string password)
        {
            return _repository.CheckUser(userName, password);
        }

    }
}
