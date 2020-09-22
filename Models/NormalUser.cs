using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodsForAll.Models
{
    public class NormalUser
    {
        [StringLength(128)]
        public string id { get; set; }
        [StringLength(32)]
        [Display(Name = "Name")]
        public string name { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(11)]
        public string phone { get; set; }
        public string location { get; set; }
    }
}