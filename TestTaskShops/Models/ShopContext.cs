using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestTaskShops.Models
{
    public class ShopContext: DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Good> Goods { get; set; }
    }
}