using Sxxy_Framework.Entitys.SystemFrameworkEntity;
using Sxxy_Framework.Service.Dtos.SystemDto;

namespace Sxxy_Framework.Service.ISystemService
{
    public interface ISystemUserService
    {
        SystemUserDto CheckUser(string userName, string password);

        SystemUserDto GetUser(string userName);
    }
}
