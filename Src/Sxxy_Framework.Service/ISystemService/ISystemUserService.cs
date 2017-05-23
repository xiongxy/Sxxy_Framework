using Sxxy_Framework.Entitys.SystemFrameworkEntity;

namespace Sxxy_Framework.Service.ISystemService
{
    public interface ISystemUserService
    {
        SystemUser CheckUser(string userName, string password);
    }
}
