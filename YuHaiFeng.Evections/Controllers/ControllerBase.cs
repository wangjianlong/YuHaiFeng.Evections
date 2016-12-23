using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuHaiFeng.Evections.Common;
using YuHaiFeng.Evections.Managers;
using YuHaiFeng.Evections.Models;

namespace YuHaiFeng.Evections.Controllers
{
    [UserAuthorize]
    public class ControllerBase : AsyncController
    {
        protected ManagerCore Core = ManagerCore.Instance;

        protected UserIdentity Identity
        {
            get
            {
                return (UserIdentity)HttpContext.User.Identity;
            }
        }

        protected ActionResult SuccessJsonResult(object data = null)
        {
            return new ContentResult { Content = new { result = 1, content = "操作成功", data }.ToJson(), ContentEncoding = System.Text.Encoding.UTF8, ContentType = "text/json" };
        }

        protected ActionResult ErrorJsonResult(string message)
        {
            return new ContentResult { Content = new { result = 0, content = message }.ToJson(), ContentEncoding = System.Text.Encoding.UTF8, ContentType = "text/json" };
        }

        protected ActionResult ErrorJsonResult(Exception ex)
        {
            return new ContentResult { Content = new { result = 0, content = ex.Message, data = ex }.ToJson(), ContentEncoding = System.Text.Encoding.UTF8, ContentType = "text/json" };
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.Controller = filterContext.RequestContext.RouteData.Values["controller"];
            ViewBag.Action = filterContext.RequestContext.RouteData.Values["action"];
            ViewBag.Identity = Identity;
            base.OnActionExecuting(filterContext);
        }

    }
}
