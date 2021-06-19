using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneShop.Models
{
    public class ShopContext: DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ShopContext(DbContextOptions<ShopContext> opt): base(opt)
        {
            Database.EnsureCreated();
        }
    }
}
