using CarMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Data.Models
{
    public class CartMarketItem
    {
        public int Id { get; set; }
        public CarModel car { get; set; }
        public int prise { get; set; }

        public string CartMarketId { get; set; }
    }
}
