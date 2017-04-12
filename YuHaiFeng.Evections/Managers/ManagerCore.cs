using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuHaiFeng.Evections.Managers
{
    public class ManagerCore
    {
        public static readonly ManagerCore Instance = new ManagerCore();
        private ManagerCore()
        {
            foreach (var p in this.GetType().GetProperties())
            {
                if (p.PropertyType == this.GetType())
                {
                    continue;
                }
                var val = p.GetValue(this);
                if (val == null)
                {
                    p.SetValue(this, Activator.CreateInstance(p.PropertyType));
                }
            }
        }

        public UserManager UserManager { get; private set; }
        public EvectionManager EvectionManager { get; private set; }
        public ERelationManager ERelationManager { get; private set; }
        public Evection_UserManager Evection_UserManager { get; private set; }
        public QQManager QQManager { get; private set; }
    }
}