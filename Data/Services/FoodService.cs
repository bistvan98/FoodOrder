using FoodOrder.Data.Base;
using FoodOrder.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.Data.Services
{
    public class FoodService : EntityBaseRepository<Food>, IFoodService
    {
        public FoodService(AppDbContext context) : base(context) { }
    }
}
