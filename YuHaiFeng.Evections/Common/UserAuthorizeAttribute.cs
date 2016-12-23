using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YuHaiFeng.Evections.Common
{
    [AttributeUsage(AttributeTargets.All,Inherited =true)]
    public class UserAuthorizeAttribute:System.Web.Mvc.AuthorizeAttribute
    {
        private bool _enable { get; set; }
        public UserAuthorizeAttribute(bool enable = true)
        {
            _enable = enable;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return httpContext.User.Identity.IsAuthenticated;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (_enable)
            {
                var retureUrl = filterContext.HttpContext.Request.Url.AbsoluteUri;
                filterContext.HttpContext.Response.Redirect("/User/Login?retureUrl=" + HttpUtility.UrlEncode(retureUrl));
            }
        }
    }
}