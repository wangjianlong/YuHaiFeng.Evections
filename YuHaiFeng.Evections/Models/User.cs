using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YuHaiFeng.Evections.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string LoginName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string AccessToken { get; set; }

    }


    public static class UserHelper
    {
        public static List<User> RemoveExecpt(this List<User> list,List<string> removes)
        {
            if (removes == null || removes.Count == 0)
            {
                return list;
            }
            var born = new List<User>();
            foreach(var item in list)
            {
                if (!removes.Contains(item.Name))
                {
                    born.Add(item);
                }
            }
            return born;
        }
    }
}