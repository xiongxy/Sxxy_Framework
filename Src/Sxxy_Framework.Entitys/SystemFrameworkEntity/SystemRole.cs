using System.Collections.Generic;
using Sxxy_Framework.Entitys;

namespace Sxxy_Framework.Entitys.SystemFrameworkEntity
{
    public class SystemRole : BaseEntity
    {
        /// <summary>
        /// 角色编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 角色备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 角色所拥有用户
        /// </summary>
        public  ICollection<SystemUser> SystemUsers { get; set; }
        /// <summary>
        /// 角色所拥有菜单功能
        /// </summary>
        public  ICollection<SystemMenu> SystemMenus { get; set; }
    }
}
