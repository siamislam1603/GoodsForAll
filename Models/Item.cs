using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodsForAll.Models
{
    public class Item
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Item Name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Quantity")]
        public int quantity { get; set; }
        [Required]
        [Display(Name = "Location")]
        public string location { get; set; }
        [Required]
        [Display(Name = "Expire Data")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public NormalUser NormalUser { get; set; }
        public string NormalUserId { get; set; }
        public DonationType DonationType { get; set; }
        [Display(Name ="Donation Type")]
        public byte DonationTypeId { get; set; }
    }
}