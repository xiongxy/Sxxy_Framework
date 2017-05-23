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
                //����û���Ϣ
                var user = _systemUserService.CheckUser(model.UserName, model.Password);
                if (user != null)
                {
                    //��¼Session
                    HttpContext.Session.Set("CurrentUser", ByteConvertHelper.ObjectToBytes(user));
                    //��ת��ϵͳ��ҳ
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.ErrorInfo = "�û������������";
                return View();
            }
            ViewBag.ErrorInfo = ModelState.Values.First().Errors[0].ErrorMessage;
            return View(model);
        }
    }
}