using System;
using System.Collections.Generic;
using System.Text;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;

namespace Sxxy_Framework.Repository.IEntityRepository
{
    /// <summary>
    /// 用户管理仓储接口
    /// </summary>
    public interface ISystemUserRepository 
    {
        /// <summary>
        /// 检查用户是存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>存在返回用户实体，否则返回NULL</returns>
        SystemUser CheckUser(string userName, string password);
    }
}
