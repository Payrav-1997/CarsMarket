using CarMarket.Data.Interfaces;
using CarMarket.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDbContent appDbContent;
        public CarRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<CarModel> Cars => appDbContent.Car.Include(c => c.Category);

        public IEnumerable<CarModel> getFavCars => appDbContent.Car.Where(p => p.isFavorite).Include(c => c.Category);

        public CarModel getObjectCar(int carId) => appDbContent.Car.FirstOrDefault(p => p.Id == carId);
       
    }
}
