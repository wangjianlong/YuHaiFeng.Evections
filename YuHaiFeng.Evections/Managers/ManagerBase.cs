using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YuHaiFeng.Evections.Models;

namespace YuHaiFeng.Evections.Managers
{
    public class ManagerBase
    {
        protected DataContext GetDbContext()
        {
            return new DataContext();
        }
    }
}