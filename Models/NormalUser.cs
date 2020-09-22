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
        [StringLength(maximumLength:32,MinimumLength =4)]
        [Display(Name = "Name")]
        public string name { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(maximumLength: 11, MinimumLength = 11)]
        public string phone { get; set; }
        public string location { get; set; }
    }
}