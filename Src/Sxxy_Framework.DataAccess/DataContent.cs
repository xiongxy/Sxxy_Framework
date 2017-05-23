using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
            var db = service.GetService(typeof(DataContent)) as DataContent;
            if (db?.Database != null && db.Database.EnsureCreated())
            {
                IntitData(db);
                db.SaveChangesAsync();
            }
        }

        public static void IntitData(DataContent db)
        {
            if (db.SystemUsers.Any())
                return;



            db.SystemUsers.Add(new SystemUser()
            {
                Id = new Guid(),
                UserName = "admin",
                Password = "123456",
                Name = "超级管理员",
                SystemDepartment = new SystemDepartment
                {
                    Id = new Guid(),
                    DepartmentName = "Sxxy_管理部"
                },
                SystemRole = new SystemRole
                {
                    Id = new Guid(),
                    Name = "超级管理员",
                    Code = "C00001",
                }
            });














            //    db.SystemDepartments.Add(new SystemDepartment() { Id = new Guid(), DepartmentName = "Sxxy_管理部" });
            //    db.SystemUsers.Add(new SystemUser() { Id = new Guid(), UserName = "admin", Password = "123456", Name = "超级管理员" });
            //    db.SystemMenus.Add(new SystemMenu() { Id = new Guid(), Name = "组织机构管理", Code = "Department", SerialNumber = 0, ParentId = Guid.Empty, Icon = "fa fa-link" });
            //    db.SystemMenus.Add(new SystemMenu() { Id = new Guid(), Name = "角色管理", Code = "Role", SerialNumber = 1, ParentId = Guid.Empty, Icon = "fa fa-link" });
            //    db.SystemMenus.Add(new SystemMenu() { Id = new Guid(), Name = "用户管理", Code = "User", SerialNumber = 2, ParentId = Guid.Empty, Icon = "fa fa-link" });
            //    db.SystemMenus.Add(new SystemMenu() { Id = new Guid(), Name = "功能管理", Code = "Menu", SerialNumber = 3, ParentId = Guid.Empty, Icon = "fa fa-link" });
        }
    }
}
