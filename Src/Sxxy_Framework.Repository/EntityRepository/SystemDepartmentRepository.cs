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
    public class SystemDepartmentRepository : RepositoryBase<SystemDepartment>, ISystemDepartmentRepository
    {
        public SystemDepartmentRepository(DataContent dataContent) : base(dataContent)
        {
        }
    }
}
