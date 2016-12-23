using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using YuHaiFeng.Evections.Models;

namespace YuHaiFeng.Evections.Common
{
    public static  class AuthUtils
    {
        private const string _cookieName = ".user";
        public static string GenerateToken(this HttpContextBase context,User user)
        {
            var ticket = new FormsAuthenticationTicket(1, user.ID + "|" + user.Name + "|" + user.LoginName, DateTime.Now, DateTime.MaxValue, true, "user_token");
            var token = FormsAuthentication.Encrypt(ticket);
            return token;
        }
        public static void SaveAuth(this HttpContextBase context,User user)
        {
            user.AccessToken = GenerateToken(context, user);
            var cookie = new HttpCookie(_cookieName, user.AccessToken);
            context.Response.Cookies.Remove(_cookieName);
            context.Response.Cookies.Add(cookie);
        }

        public static void ClearAuth(this HttpContextBase context)
        {
            var cookie = context.Request.Cookies.Get(_cookieName);
            if (cookie == null) return;
            cookie.Value = null;
            cookie.Expires = DateTime.Now.AddHours(2);
            context.Response.SetCookie(cookie);
        }
        private static string GetToken(HttpContextBase context)
        {
            var token = context.Request.Headers["token"];
            if (string.IsNullOrEmpty(token))
            {
                var cookie = context.Request.Cookies.Get(_cookieName);
                if (cookie != null)
                {
                    token = cookie.Value;
                }
            }
            return token;
        }
        public static UserIdentity GetCurrentUser(this HttpContextBase context)
        {
            var token = GetToken(context);
            if (!string.IsNullOrEmpty(token))
            {
                var ticket = FormsAuthentication.Decrypt(token);
                if (ticket != null && !string.IsNullOrEmpty(ticket.Name))
                {
                    var value = ticket.Name.Split('|');
                    if (value.Length == 3)
                    {
                        int a = 0;
                        return new UserIdentity
                        {
                            UserID = int.TryParse(value[0], out a) ? a : 0,
                            Name = value[1],
                            LoginName = value[2]
                        };
                    }
                }
            }
            return UserIdentity.Guest;
        }
    }
}