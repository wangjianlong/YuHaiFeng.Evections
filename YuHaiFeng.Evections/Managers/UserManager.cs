using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YuHaiFeng.Evections.Common;
using YuHaiFeng.Evections.Models;

namespace YuHaiFeng.Evections.Managers
{
    public class UserManager:ManagerBase
    {
        /// <summary>
        /// 作用：通过登录名字以及密码获取用户信息  密码不需要加密
        /// 作者：汪建龙
        /// 编写时间：2016年12月23日14:46:03
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User Get(string loginName,string password)
        {
            using (var db = GetDbContext())
            {
                password = password.MD5();
                return db.Users.FirstOrDefault(e => e.LoginName == loginName && e.Password == password);
            }
        }

        /// <summary>
        /// 作用：获取所有用户列表
        /// 作者：汪建龙
        /// 编写时间：2016年12月23日15:25:33
        /// </summary>
        /// <returns></returns>
        public List<User> Get()
        {
            using (var db = GetDbContext())
            {
                return db.Users.OrderBy(e => e.ID).ToList();
            }
        }

        /// <summary>
        /// 作用：验证目前系统中是否已存在 存在  true  不存在 false
        /// 作者：汪建龙
        /// 编写时间：2016年12月23日15:32:01
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Exist(string name)
        {
            using (var db = GetDbContext())
            {
                var entry = db.Users.FirstOrDefault(e => e.Name.ToUpper() == name.ToUpper());
                return entry != null;
            }
        }

        /// <summary>
        /// 作用：纯粹添加用户一个用户  没有登录名称以及密码的
        /// 作者：汪建龙
        /// 编写时间：2016年12月23日15:34:48
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int Add(string name)
        {
            using (var db = GetDbContext())
            {
                var entry = new User { Name = name };
                db.Users.Add(entry);
                db.SaveChanges();
                return entry.ID;
            }
        }

    }
}