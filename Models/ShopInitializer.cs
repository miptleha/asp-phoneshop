using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneShop.Models
{
    public class ShopInitializer
    {
        public static void Initialize(ShopContext db)
        {
            if (!db.Phones.Any())
            {
                db.Phones.Add(new Phone { Name = "Redmi 9", Manufacturer = "Xiaomi", Price = 200 });
                db.Phones.Add(new Phone { Name = "XPeria 10", Manufacturer = "Sony", Price = 500 });
                db.Phones.Add(new Phone { Name = "Galaxy S11", Manufacturer = "Samsung", Price = 1000 });
                db.Phones.Add(new Phone { Name = "IPhone 11", Manufacturer = "Apple", Price = 1500 });
                db.SaveChanges();
            }
        }
    }
}
