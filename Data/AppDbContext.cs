using FoodOrder.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FoodOrder.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}
