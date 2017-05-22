﻿using System;
using System.Collections.Generic;

namespace Sxxy_Framework.Model.SystemFrameworkModel
{
    public class SystemUser : BaseEntity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// 登录次数
        /// </summary>
        public int LoginTimes { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public Guid DeptmentId { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public int IsDeleted { get; set; }

        ///// <summary>
        ///// 所属部门实体
        ///// </summary>
        //public virtual SystemDepartment Department { get; set; }

        ///// <summary>
        ///// 角色集合
        ///// </summary>
        //public virtual ICollection<SystemRole> Roles { get; set; }
    }
}
