using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodsForAll.Models
{
    public class Volunter
    {
        [StringLength(128)]
        public string id { get; set; }
        public bool status { get; set; }
        public bool task { get; set; }
    }
}