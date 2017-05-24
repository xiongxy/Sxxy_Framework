using System;
using System.Collections.Generic;
using System.Text;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;

namespace Sxxy_Framework.Repository.IEntityRepository
{
    /// <summary>
    /// 用户管理仓储接口
    /// </summary>
    public interface ISystemUserRepository : IRepository<SystemUser, Guid>
    {
    }
}
