using CarMarket.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Data
{
    public class DBobjects
    {
        public static void Initial(AppDbContent content)
        {
            
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Car.Any())
            {
                content.AddRange(
                    new CarModel
                    {
                        name = "Tesla",
                        shortDesc = "Тихий спокойный",
                        longDesk = "Удобный автомобиль",
                        img = "/img/t1.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Tesla"]
                    },

                    new CarModel
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesk = "Удобный автомобиль",
                        img = "/img/b.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["BMW"]
                    },

                    new CarModel
                    {
                        name = "Mercedes c class",
                        shortDesc = "Уютный и большой",
                        longDesk = "Удобный автомобиль",
                        img = "/img/m.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Mercedes"]
                    },
                    
                    new CarModel
                    {
                        name = "Jiguli",
                        shortDesc = "Дерзкий и стильный",
                        longDesk = "Удобный автомобиль",
                        img = "/img/j.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Lada"]
                    }
                    );
            }
            content.SaveChanges();


        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                         new Category {categoryName = "Tesla",desc = "Современный вид транспорта"},
                         new Category {categoryName = "BMW",desc = "Современный вид транспорта"},
                         new Category {categoryName = "Mercedes",desc = "Современный вид транспорта"},
                         new Category {categoryName = "Lada",desc = "Современный вид транспорта"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach  (Category element in list)
                    {
                        category.Add(element.categoryName, element);
                    }
                    
                }
                return category;
            }
        }
    }
}
