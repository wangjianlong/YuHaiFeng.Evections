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
    }
}