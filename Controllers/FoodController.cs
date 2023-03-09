using FoodOrder.Data;
using FoodOrder.Data.Services;
using FoodOrder.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrder.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodService _service;

        public FoodController(IFoodService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allFoods = await _service.GetAllAsync();
            return View(allFoods);
        }

        //GET: Food/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, Price, Description, FoodType, PathToImage, IsVegetarian")]Food food)
        {
            if(!ModelState.IsValid)
            {
                return View(food);
            }
            await _service.AddAsync(food);
            return RedirectToAction(nameof(Index));
        }

        //GET: Foods/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var foodDetails = await _service.GetByIdAsync(id);

            if(foodDetails == null)
            {
                return View("Empty");
            }

            return View(foodDetails);
        }
    }
}
