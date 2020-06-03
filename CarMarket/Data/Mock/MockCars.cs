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
                     img="https://www.pinterest.com/pin/762937993101915288/",
                     price=45000,
                     isFavorite=true,
                     available=true,
                     Category=_categoryCars.AllCategories.Last()
                    },

                    new CarModel
                    {name = "BMW M3",
                     shortDesc="Дерзкий и стильный",
                     longDesk="Удобный автомобиль",
                     img=" https://www.google.com/url?sa=i&url=https%3A%2F%2Fauto.ria.com%2Fauto_bmw_m3_24807312.html&psig=AOvVaw1fcUMgOLDYVNQTMjgkxICK&ust=1591007424951000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCKi32Njy3ekCFQAAAAAdAAAAABAa",
                     price=45000,
                     isFavorite=true,
                     available=true,
                     Category=_categoryCars.AllCategories.Last()
                    },

                    new CarModel
                    {name = "Mercedes c class",
                     shortDesc="Уютный и большой",
                     longDesk="Удобный автомобиль",
                     img="https://www.google.com/url?sa=i&url=http%3A%2F%2Fwww.motorpage.ru%2FMercedesBenz%2FSClass%2Fw222%2Fphotos%2F&psig=AOvVaw31DPoU6S8GDwEKCXrZ8KL0&ust=1591007572404000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCKCnpZ7z3ekCFQAAAAAdAAAAABAD",
                     price=45000,
                     isFavorite=true,
                     available=true,
                     Category=_categoryCars.AllCategories.Last()
                    },

                    new CarModel
                    {name = "Jiguli",
                     shortDesc="Дерзкий и стильный",
                     longDesk="Удобный автомобиль",
                     img="https://www.google.com/url?sa=i&url=https%3A%2F%2Fauto.mail.ru%2Farticle%2F70759-samye_krasivye_zhiguli_fotoreportazh%2F&psig=AOvVaw3Z8rPEYr4qql1kcQfIY0h1&ust=1591007649496000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCOC67sLz3ekCFQAAAAAdAAAAABAD",
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
