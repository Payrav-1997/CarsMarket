using CarMarket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Data.Models
{
    public class Cart
    {
        private readonly AppDbContent appDbContent;
        public Cart(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public string CartMarketId { get; set; }

        public List<CartMarketItem> listCartItems { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetRequiredService<AppDbContent>();
            string cartMarketId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartMarketId);
            return new Cart(context) { CartMarketId = cartMarketId };
        }

        public void AddToCart (CarModel car)
        {
            appDbContent.CartMarketItem.Add(new CartMarketItem {

             CartMarketId= CartMarketId,
             car = car,
             prise = car.price

            });
            appDbContent.SaveChanges();
        }

        public List<CartMarketItem> getMarketItems()
        {
            return appDbContent.CartMarketItem.Where(c =>c.CartMarketId==CartMarketId).Include(p => p.car).ToList();
        }
    }
}
