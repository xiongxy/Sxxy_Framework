using System;
using Sxxy_Framework.Entitys;
using System.ComponentModel.DataAnnotations;
namespace Sxxy_Framework.Entitys.SystemFrameworkEntity
{
    public class SystemMenu : BaseEntity
    {   /// <summary>
        /// 父级ID
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int SerialNumber { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 菜单编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 菜单地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 类型：0导航菜单；1操作按钮。
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 菜单图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 菜单备注
        /// </summary>
        public string Remarks { get; set; }


        /// <summary>
        /// 角色
        /// </summary>
        public SystemRole SystemRole { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public Guid SystemRoleId { get; set; }

    }
}
