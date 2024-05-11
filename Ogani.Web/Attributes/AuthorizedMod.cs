﻿using Ogani.Web.Extensions;
using Ogani.BusinessLogic.Interfaces;
using Ogani.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ogani.Web.Attributes
{
    public class AuthorizedMod : ActionFilterAttribute
    {
        private readonly ISession _session;
        public AuthorizedMod()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _session = bl.GetSessionBL();
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var apiCookie = HttpContext.Current.Request.Cookies["X-KEY"];
            if (apiCookie != null)
            {
                var user = _session.GetUserByCookie(apiCookie.Value);
                if (user != null && (user.Level == Domain.Enum.URole.USER || user.Level == Domain.Enum.URole.ADMINISTRATOR))
                {
                    HttpContext.Current.SetMySessionObject(user);
                    filterContext.Controller.ViewBag.AuthorizedUser = user;
                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index" }));
                }
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index" }));
            }
        }
    }
}