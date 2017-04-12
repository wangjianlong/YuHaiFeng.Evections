using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YuHaiFeng.Evections.Common;
using YuHaiFeng.Evections.Models;
using YuHaiFeng.Evections.Parameters;

namespace YuHaiFeng.Evections.Managers
{
    public class QQManager:ManagerBase
    {
        public void SaveRange(List<QQ> list)
        {
            foreach(var qq in list)
            {
                var id = Save(qq);
                
            }
        }

        public int Save(QQ qq)
        {
            if(Exist(qq.Number))
            {
                return 0;
            }
            using (var db = GetDbContext())
            {
                db.QQs.Add(qq);
                db.SaveChanges();
                return qq.ID;
            }
        }

        public bool Exist(string number)
        {
            using (var db = GetDbContext())
            {
                return db.QQs.Any(e => e.Number.ToLower() == number.ToLower());
            }
        }

        public List<string> GetRemark()
        {
            using (var db = GetDbContext())
            {
                return db.QQs.GroupBy(e => e.Remark).Select(e => e.Key).ToList();
            }
        }
        public List<QQ> GetList()
        {
            using (var db = GetDbContext())
            {
                return db.QQs.ToList();
            }
        }

        public List<QQ> GetList(string remark)
        {
            using (var db = GetDbContext())
            {
                return db.QQs.Where(e => e.Remark.ToLower() == remark.ToLower()).ToList();
            }
        }

        public List<QQ> Search(QQParameter parameter)
        {
            using (var db = GetDbContext())
            {
                var query = db.QQs.AsQueryable();

                if (!string.IsNullOrEmpty(parameter.Number))
                {
                    query = query.Where(e => e.Number.ToLower().Contains(parameter.Number.ToLower()));
                }

                if (!string.IsNullOrEmpty(parameter.Remark))
                {
                    query = query.Where(e => e.Remark.ToLower().Contains(parameter.Remark.ToLower()));
                }
                query = query.OrderBy(e => e.Time).SetPage(parameter.Page);
                return query.ToList();
            }
        }
    }
}