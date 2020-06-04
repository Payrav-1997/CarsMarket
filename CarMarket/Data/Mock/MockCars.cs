using CarMarket.Data.Interfaces;
using CarMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Data.Mock
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<CarModel> Cars
        {
            get
            {
                return new List<CarModel>
                {

                    new CarModel
                    {name = "Tesla",
                     shortDesc="Тихий спокойный",
                     longDesk="Удобный автомобиль",
                     img="/img/t1.jpg",
                     price=45000,
                     isFavorite=true,
                     available=true,
                     Category=_categoryCars.AllCategories.Last()
                    },

                    new CarModel
                    {name = "BMW M3",
                     shortDesc="Дерзкий и стильный",
                     longDesk="Удобный автомобиль",
                     img="/img/b.jpg",
                     price=45000,
                     isFavorite=true,
                     available=true,
                     Category=_categoryCars.AllCategories.Last()
                    },

                    new CarModel
                    {name = "Mercedes c class",
                     shortDesc="Уютный и большой",
                     longDesk="Удобный автомобиль",
                     img="/img/m.jpg",
                     price=45000,
                     isFavorite=true,
                     available=true,
                     Category=_categoryCars.AllCategories.Last()
                    },

                    new CarModel
                    {name = "Jiguli",
                     shortDesc="Дерзкий и стильный",
                     longDesk="Удобный автомобиль",
                     img="/img/j.jpg",
                     price=45000,
                     isFavorite=true,
                     available=true,
                     Category=_categoryCars.AllCategories.Last()
                    }

                };
            }
        }
        public IEnumerable<CarModel> getFavCars { get; set; }

        public CarModel getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
