using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YuHaiFeng.Evections.Controllers
{
    public class HomeController : ControllerBase
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        public ActionResult EUView()
        {
            var dict = Core.Evection_UserManager.Get().GroupBy(e => e.Time).ToDictionary(e => e.Key, e => e.ToList());
            ViewBag.Dict = dict;
            return View();
        }
        


    }
}
