using FoodOrder.Data;
using FoodOrder.Data.Services;
using FoodOrder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        // GET: Food/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, Price, Description, FoodType, PathToImage, IsVegetarian")] Food food)
        {
            if (!ModelState.IsValid) return View(food);

            await _service.AddAsync(food);
            return RedirectToAction(nameof(Index));
        }

        //GET: Food/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var foodDetails = await _service.GetByIdAsync(id);

            if(foodDetails == null) return View("NotFound");

            return View(foodDetails);
        }

        // GET: Food/Edit/1
        public async Task<IActionResult> EditAsync(int id)
        {
            var foodDetails = await _service.GetByIdAsync(id);

            if (foodDetails == null) return View("NotFound");

            return View(foodDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, Price, Description, FoodType, PathToImage, IsVegetarian")] Food food)
        {
            if (!ModelState.IsValid) return View(food);
            await _service.UpdateAsync(id, food);
            return RedirectToAction(nameof(Index));
        }

        // GET: Food/Delete/1
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var foodDetails = await _service.GetByIdAsync(id);

            if (foodDetails == null) return View("NotFound");

            return View(foodDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foodDetails = await _service.GetByIdAsync(id);
            if(foodDetails == null) return View();

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
