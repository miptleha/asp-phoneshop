using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Buyer { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}
