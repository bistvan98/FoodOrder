using FoodOrder.Data;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrder.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly AppDbContext _context;

        public RestaurantController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allRestaurants = _context.Restaurants.ToList();
            return View(allRestaurants);
        }
    }
}
