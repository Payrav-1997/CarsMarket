using CarMarket.Data.Interfaces;
using CarMarket.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly Cart cart;

        public OrderController(IAllOrders allOrders, Cart cart)
        {
            this.allOrders = allOrders;
            this.cart = cart;
        }

        public IActionResult Checkout()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            cart.listCartItems = cart.getMarketItems();

            if (cart.listCartItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас длжны быть товары!");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Comlete()
        {
            ViewBag.Massage = "Заказ успешно обработан";
            return View();
        }
    }
}
