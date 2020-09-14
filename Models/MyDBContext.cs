using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoodsForAll.Models
{
    public class MyDBContext
    {
        public DbSet<NormalUser> NormalUsers { get; set; }
    }
}