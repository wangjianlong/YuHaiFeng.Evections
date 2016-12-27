using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YuHaiFeng.Evections.Models;

namespace YuHaiFeng.Evections.Managers
{
    public class Evection_UserManager:ManagerBase
    {
        public List<Evection_User_View> Get(DateTime startTime,DateTime endTime)
        {
            using (var db = GetDbContext())
            {
                return db.Evection_User_Views.Where(e => (e.StartTime <= startTime && startTime <= e.EndTime) || (e.StartTime <= endTime && endTime <= e.EndTime)).ToList();
            }
        }
        public List<Evection_User_View> Get()
        {
            using (var db = GetDbContext())
            {
                return db.Evection_User_Views.ToList();
            }
        }
    }
}