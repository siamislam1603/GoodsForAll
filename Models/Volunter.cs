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
        [StringLength(maximumLength: 32, MinimumLength = 4)]
        public string name { get; set; }
        public bool status { get; set; }
        public bool task { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(maximumLength: 11, MinimumLength = 11)]
        public string phone { get; set; }
        public string location { get; set; }
    }
}