using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuHaiFeng.Evections.Common;
using YuHaiFeng.Evections.Models;

namespace YuHaiFeng.Evections.Controllers
{
    [UserAuthorize(false)]
    public class UserController : ControllerBase
    {

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string loginName,string password)
        {
            if (string.IsNullOrEmpty(loginName) || string.IsNullOrEmpty(password))
            {
                return ErrorJsonResult("登录名以及密码不能为空！");
            }
            var user = Core.UserManager.Get(loginName, password);
            if (user == null)
            {
                return ErrorJsonResult("当前系统中未存在用户！");
            }
            HttpContext.SaveAuth(user);
            return SuccessJsonResult();
        }

        public ActionResult LoginOut()
        {
            HttpContext.ClearAuth();
            return RedirectToAction("Login");
        }

    }
}
