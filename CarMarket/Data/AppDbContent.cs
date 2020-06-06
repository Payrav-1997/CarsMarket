using System;
using System.Collections.Generic;
using System.Text;
using CarMarket.Data.Models;
using CarMarket.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarMarket.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options)
            : base(options)
        {

        }
        public DbSet<CarModel> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CartMarketItem> CartMarketItem { get; set; }


    }
}
