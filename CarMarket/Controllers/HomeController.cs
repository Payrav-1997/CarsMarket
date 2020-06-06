using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarMarket.Models;
using CarMarket.Data.Interfaces;
using CarMarket.Views.ViewModels;

namespace CarMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public HomeController(IAllCars iAllCars)
        {
            _allCars = iAllCars;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _allCars.getFavCars
            };
            return View(homeCars);
        }
    }
}
