using CarMarket.Data.Interfaces;
using CarMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Data.Mock
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Электромобили",desc="Современный вид транспорта"},
                    new Category{categoryName = "Классические автомобили",desc="Машины с дивгателем внутренного згорания"},

                };
            }
        }
    }
}
