using CarMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<CarModel> Cars { get; }
        IEnumerable<CarModel> getFavCars { get; }
        CarModel getObjectCar(int carId);
    }
}
