using CarMarket.Data.Interfaces;
using CarMarket.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContent appDbContent;
        private readonly Cart cart;

        public OrdersRepository(AppDbContent appDbContent,Cart cart)
        {
            this.appDbContent = appDbContent;
            this.cart = cart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDbContent.Order.Add(order);

            var items = cart.listCartItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarID = item.car.Id,
                    orderID = order.id,
                    prise = item.car.price
                };
                appDbContent.OrderDetail.Add(orderDetail);
            }
            appDbContent.SaveChanges();
        }
    }
}
