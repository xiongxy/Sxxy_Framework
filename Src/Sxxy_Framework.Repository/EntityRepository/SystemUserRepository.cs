using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sxxy_Framework.DataAccess;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;
using Sxxy_Framework.Repository.IEntityRepository;

namespace Sxxy_Framework.Repository.EntityRepository
{
    /// <summary>
    /// 用户管理仓储接口
    /// </summary>
    public class SystemUserRepository : RepositoryBase<SystemUser>, ISystemUserRepository
    {
        private readonly DataContent _dataContent;
        public SystemUserRepository(DataContent dataContent) : base(dataContent)
        {
            _dataContent = dataContent;
        }

        /// <summary>
        /// 检查用户是存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>存在返回用户实体，否则返回NULL</returns>
        SystemUser ISystemUserRepository.CheckUser(string userName, string password)
        {
            return _dataContent.Set<SystemUser>().FirstOrDefault(it => it.UserName == userName && it.Password == password);
        }

    }
}
