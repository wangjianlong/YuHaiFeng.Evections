using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace YuHaiFeng.Evections.Models
{
    public class UserIdentity:System.Security.Principal.IIdentity
    {
        public static readonly UserIdentity Guest = new UserIdentity();
        public int UserID { get; set; }
        public string LoginName { get; set; }
        public string Name { get; set; }
        public string AuthenticationType { get { return "Web.Session"; } }
        public bool IsAuthenticated { get { return UserID > 0; } }

    }

    public class UserPrincipal : System.Security.Principal.IPrincipal
    {
        public UserPrincipal(IIdentity identity)
        {
            Identity = identity;
        }
        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
        public IIdentity Identity { get; private set; }
    }
}