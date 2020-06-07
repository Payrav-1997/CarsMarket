using CarMarket.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);

    }
}
