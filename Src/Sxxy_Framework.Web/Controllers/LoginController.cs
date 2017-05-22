using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sxxy_Framework.Service.IService;

namespace Sxxy_Framework.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISystemUserService _systemUserService;
        public LoginController(ISystemUserService systemUserService)
        {
            _systemUserService = systemUserService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var user = _systemUserService.CheckUser("admin", "123456");
            return View();
        }
    }
}