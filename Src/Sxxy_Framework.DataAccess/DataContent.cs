using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;

namespace Sxxy_Framework.DataAccess
{
    public class DataContent : DbContext
    {
        public DataContent()
        {
        }

        public DataContent(DbContextOptions options) : base(options) { }

        public DbSet<SystemDepartment> SystemDepartments { get; set; }
        public DbSet<SystemMenu> SystemMenus { get; set; }
        public DbSet<SystemRole> SystemRoles { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }

        public static void InitDb(IServiceProvider service)
        {
            var context = service.GetService(typeof(DataContent)) as DataContent;
            //var context = new DataContent(service.GetRequiredService<DbContextOptions<DataContent>>())
            if (context?.Database != null && context.Database.EnsureCreated())
            {
                IntitData(context);
                context.SaveChanges();
            }
        }

        public static void IntitData(DataContent context)
        {

            if (context.SystemDepartments.Any())
                return;


            var departmentId = Guid.NewGuid();
            context.SystemDepartments.Add(new SystemDepartment() { Id = departmentId, DepartmentName = "Sxxy_管理部", ParentId = Guid.Empty, IsDeleted = 0 });


            var superRoleId = Guid.NewGuid();
            context.SystemRoles.Add(new SystemRole() { Id = superRoleId, Code = "超级管理员" });



            var superUserId = Guid.NewGuid();
            context.SystemUsers.Add(new SystemUser() { Id = superUserId, UserName = "admin", Password = "123456", Name = "超级管理员", SystemDepartmentId = departmentId, SystemRoleId = superRoleId, IsDeleted = 0, });
           
            var systemId =  Guid.NewGuid();
            context.SystemMenus.Add(new SystemMenu() { Id = systemId, Name = "系统", Code = "System", SerialNumber = -1, ParentId = Guid.Empty, Icon = "fa fa-link", Type = 0, SystemRoleId = superRoleId });
            context.SystemMenus.Add(new SystemMenu() { Id = Guid.NewGuid(), Name = "组织机构管理", Code = "Department", SerialNumber = 0, ParentId = systemId, Icon = "fa fa-link", Type = 0, SystemRoleId = superRoleId });
            context.SystemMenus.Add(new SystemMenu() { Id = Guid.NewGuid(), Name = "角色管理", Code = "Role", SerialNumber = 1, ParentId = systemId, Icon = "fa fa-link", Type = 0, SystemRoleId = superRoleId });
            context.SystemMenus.Add(new SystemMenu() { Id = Guid.NewGuid(), Name = "用户管理", Code = "User", SerialNumber = 2, ParentId = systemId, Icon = "fa fa-link", Type = 0, SystemRoleId = superRoleId });
            context.SystemMenus.Add(new SystemMenu() { Id = Guid.NewGuid(), Name = "功能管理", Code = "Menu", SerialNumber = 3, ParentId = systemId, Icon = "fa fa-link", Type = 0, SystemRoleId = superRoleId });
         

        }
    }
}
