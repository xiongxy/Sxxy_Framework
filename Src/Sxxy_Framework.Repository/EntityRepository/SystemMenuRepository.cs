using System;
using System.Collections.Generic;
using System.Text;
using Sxxy_Framework.DataAccess;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;
using Sxxy_Framework.Repository.IEntityRepository;

namespace Sxxy_Framework.Repository.EntityRepository
{
    class SystemMenuRepository : RepositoryBase<SystemMenu>, ISystemMenuRepository
    {
        private readonly DataContent _dataContent;
        public SystemMenuRepository(DataContent dataContent) : base(dataContent)
        {
            _dataContent = dataContent;
        }
    }
}
