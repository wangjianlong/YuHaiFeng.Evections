﻿using System;
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
}