using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YuHaiFeng.Evections.Models;

namespace YuHaiFeng.Evections.Managers
{
    public class ERelationManager:ManagerBase
    {
        public void AddRange(List<ERelation> list)
        {
            using (var db = GetDbContext())
            {
                db.ERelations.AddRange(list);
                db.SaveChanges();
            }
        }
    }
}