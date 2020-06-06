using CarMarket.Data.Interfaces;
using CarMarket.Data.Models;
using CarMarket.Data.Repository;
using CarMarket.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Controllers
{
    public class MarketCartController : Controller
    {
        private readonly IAllCars _carRepository;
        private readonly Cart _cart;

        public MarketCartController(IAllCars carRep, Cart cart)
        {
            _carRepository = carRep;
            _cart = cart;
        }
        public ViewResult Index()
        {
            var items = _cart.getMarketItems();
            _cart.listCartItems = items;

            var obj = new MarketCartViewModel
            {
                cart = _cart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart ( int id )
        {
            var item = _carRepository.Cars.FirstOrDefault(p=>p.Id==id);
            if (item != null)
            {
                _cart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
            
    }
}
