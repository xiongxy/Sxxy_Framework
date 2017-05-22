using System.Collections.Generic;

namespace Sxxy_Framework.Model.SystemFrameworkModel
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

        ///// <summary>
        ///// 角色所拥有用户
        ///// </summary>
        //public virtual ICollection<SystemUser> Users { get; set; }
        ///// <summary>
        ///// 角色所拥有菜单功能
        ///// </summary>
        //public virtual ICollection<SystemMenu> Menus { get; set; }
    }
}
