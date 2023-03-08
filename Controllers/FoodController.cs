using FoodOrder.Data;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrder.Controllers
{
    public class FoodController : Controller
    {
        private readonly AppDbContext _context;

        public FoodController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allFoods = _context.Foods.ToList();
            return View(allFoods);
        }
    }
}
