using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YuHaiFeng.Evections.Models;

namespace YuHaiFeng.Evections.Managers
{
    public class EvectionManager:ManagerBase
    {
        public bool Vaildate(int uid,DateTime startTime,DateTime endTime)
        {
            return false;
        }



        /// <summary>
        /// 作用：添加出差时间信息
        /// 作者：汪建龙
        /// 编写时间：2016年12月25日14:44:07
        /// </summary>
        /// <param name="evection"></param>
        /// <returns></returns>
        public int Add(Evection evection)
        {
            using (var db = GetDbContext())
            {
                db.Evections.Add(evection);
                db.SaveChanges();
                return evection.ID;
            }
        }
    }
}