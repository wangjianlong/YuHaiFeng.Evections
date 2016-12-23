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
        public ActionResult Index()
        {
            var list = Core.UserManager.Get();
            ViewBag.List = list;
            return View();
        }

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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return ErrorJsonResult("用户名称不能为空！");
            }
            if (Core.UserManager.Exist(name))
            {
                return ErrorJsonResult("系统中已存在用户名称为：" + name);
            }
            var id = Core.UserManager.Add(name);
            if (id > 0)
            {
                return SuccessJsonResult();
            }
            return ErrorJsonResult("添加用户失败！");
        }

    }
}
