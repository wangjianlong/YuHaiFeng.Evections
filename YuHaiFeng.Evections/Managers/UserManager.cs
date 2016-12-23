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

    }
}