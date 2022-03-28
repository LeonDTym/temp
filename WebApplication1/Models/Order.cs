using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneID { get; set; }
        public Phone Phone { get; set; }
    }
}
