﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using YuHaiFeng.Evections.Models;

namespace YuHaiFeng.Evections.Common
{
    public class BaseView<TModel>:WebViewPage<TModel>
    {
        public UserIdentity Identity { get; private set; }
        public BaseView()
        {
            Identity = Thread.CurrentPrincipal.Identity as UserIdentity;
        }
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}