using CarMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Views
{
    public class CarsListViewModel
    {
        public IEnumerable<CarModel> allCars { get; set; }
        public string currCategory { get; set; }
    }
}
