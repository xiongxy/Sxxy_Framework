﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Sxxy_Framework.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            byte[] result;
            context.HttpContext.Session.TryGetValue("CurrentUser", out result);
            if (result == null)
            {
                context.Result = new RedirectResult("/Login/Index");
                return;
            }
            base.OnActionExecuting(context);
        }
    }
}
