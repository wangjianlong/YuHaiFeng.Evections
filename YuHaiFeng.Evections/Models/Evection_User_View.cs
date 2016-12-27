using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YuHaiFeng.Evections.Models
{
    [Table("evection_user_view")]
    public class Evection_User_View
    {
        [Key]
        public int ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [NotMapped]
        public string Time
        {
            get
            {
                return string.Format("{0}——{1}", StartTime.ToLongDateString(), EndTime.ToLongDateString());
            }
        }
        public string Content { get; set; }
        public string Name { get; set; }
    }
}