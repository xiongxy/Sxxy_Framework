using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sxxy_Framework.Web.Controllers.Framework

{
    public class SharedController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}