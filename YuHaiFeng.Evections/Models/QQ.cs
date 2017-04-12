using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YuHaiFeng.Evections.Models
{
    [Table("qq")]
    public class QQ
    {
        public QQ()
        {
            Time = DateTime.Now;
        }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Number { get; set; }
        public DateTime Time { get; set; }
        public string Remark { get; set; }

    }
}