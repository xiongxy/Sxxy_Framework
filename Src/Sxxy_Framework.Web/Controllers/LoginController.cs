using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sxxy_Framework.Common.ConvertHelper;
using Sxxy_Framework.Service.ISystemService;
using Sxxy_Framework.Web.Model.SystemModels;

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
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //检查用户信息
                var user = _systemUserService.CheckUser(model.UserName, model.Password);
                if (user != null)
                {
                    //记录Session
                    HttpContext.Session.Set("CurrentUser", ByteConvertHelper.ObjectToBytes(user));
                    //跳转到系统首页
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.ErrorInfo = "用户名或密码错误。";
                return View();
            }
            ViewBag.ErrorInfo = ModelState.Values.First().Errors[0].ErrorMessage;
            return View(model);
        }
    }
}