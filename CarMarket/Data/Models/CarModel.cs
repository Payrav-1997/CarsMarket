using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesk { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavorite { get; set; }
        public bool available { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
