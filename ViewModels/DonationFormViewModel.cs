using GoodsForAll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodsForAll.ViewModels
{
    public class DonationFormViewModel
    {
        public IEnumerable<DonationType> donationtype { get; set; }
        public NormalUser normalUser { get; set; }
        public Item item { get; set; }
    }
}