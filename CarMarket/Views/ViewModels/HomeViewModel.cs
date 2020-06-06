using CarMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Views.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<CarModel> favCars { get; set; }
    }
}
