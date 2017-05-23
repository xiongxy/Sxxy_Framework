using System;
using System.Collections.Generic;
using System.Text;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;

namespace Sxxy_Framework.Service.IService
{
    public interface ISystemUserService
    {
        SystemUser CheckUser(string userName, string password);
    }
}
