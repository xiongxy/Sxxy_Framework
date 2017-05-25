using Microsoft.AspNetCore.Mvc;

namespace Sxxy_Framework.Web.Controllers.Framework
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}