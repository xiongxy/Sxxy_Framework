using System;
using System.Collections.Generic;
using Sxxy_Framework.Entitys;

namespace Sxxy_Framework.Entitys.SystemFrameworkEntity
{
    public class SystemDepartment : BaseEntity
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 部门负责人
        /// </summary>
        public string DepartmentManager { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 父级部门ID
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public int IsDeleted { get; set; }

        /// <summary>
        /// 包含用户
        /// </summary>
        public ICollection<SystemUser> SystemUsers { get; set; }
    }
}
