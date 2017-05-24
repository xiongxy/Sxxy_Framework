using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sxxy_Framework.DataAccess;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;
using Sxxy_Framework.Repository.IEntityRepository;

namespace Sxxy_Framework.Repository.EntityRepository
{
    class SystemMenuRepository : RepositoryBase<SystemMenu>, ISystemMenuRepository
    {
     
        public SystemMenuRepository(DataContent dataContent) : base(dataContent)
        {
       
        }
    }
}
