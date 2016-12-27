using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuHaiFeng.Evections.Models;

namespace YuHaiFeng.Evections.Controllers
{
    public class BusinessController : ControllerBase
    {
        //
        // GET: /Business/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Evection evection,int[] uid)
        {
            var eid = Core.EvectionManager.Add(evection);
            if (eid > 0)
            {
                if (uid != null && uid.Length > 0)
                {
                    var relations = uid.Select(e => new ERelation { UID = e, EID = eid }).ToList();
                    try
                    {
                        Core.ERelationManager.AddRange(relations);
                    }
                    catch(Exception ex)
                    {
                        return ErrorJsonResult(ex.ToString());
                    }
               
                    return SuccessJsonResult();
                }
            }
            return ErrorJsonResult("录入失败！");
        }

    }
}
