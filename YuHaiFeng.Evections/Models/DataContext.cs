using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YuHaiFeng.Evections.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("name=DbConnection")
        {
            Database.SetInitializer<DataContext>(null);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Evection> Evections { get; set; }
        public DbSet<ERelation> ERelations { get; set; }
        public DbSet<Evection_User_View> Evection_User_Views { get; set; }
        public DbSet<QQ> QQs { get; set; }
    }
}