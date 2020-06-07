using CarMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }

        public int orderID { get; set; }

        public int CarID { get; set; }

        public uint prise { get; set; }

        public virtual CarModel car { get; set; }

        public virtual Order order { get; set; }
 
    }
}
