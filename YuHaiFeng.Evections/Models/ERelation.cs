using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YuHaiFeng.Evections.Models
{
    [Table("erelations")]
    public class ERelation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int EID { get; set; }
        public int UID { get; set; }
        
    }
}