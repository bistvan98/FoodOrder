using FoodOrder.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly AppDbContext _context;

        public RestaurantController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allRestaurants = await _context.Restaurants.ToListAsync();
            return View(allRestaurants);
        }
    }
}
