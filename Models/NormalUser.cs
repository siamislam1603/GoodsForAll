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
        public float locationX { get; set; }
        public float locationY { get; set; }
    }
}