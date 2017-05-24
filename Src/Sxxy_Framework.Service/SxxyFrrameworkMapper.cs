using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Sxxy_Framework.Entitys.SystemFrameworkEntity;
using Sxxy_Framework.Service.Dtos.SystemDto;

namespace Sxxy_Framework.Service
{
    public class SxxyFrrameworkMapper
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<SystemMenu, SystemMenuDto>();
                cfg.CreateMap<SystemMenuDto, SystemMenu>();

                cfg.CreateMap<SystemUser, SystemUserDto>();
                cfg.CreateMap<SystemUserDto, SystemUser>();

                cfg.CreateMap<SystemDepartment, SystemDepartmentDto>();
                cfg.CreateMap<SystemDepartmentDto, SystemDepartment>();

                cfg.CreateMap<SystemRole, SystemRoleDto>();
                cfg.CreateMap<SystemRoleDto, SystemRole>();


            });
        }
    }
}
