using FoodOrder.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.Data.Services
{
    public class FoodService : IFoodService
    {
        private readonly AppDbContext _context;

        public FoodService(AppDbContext context)
        {
            _context = context;
        }


        public async Task AddAsync(Food food)
        {
            await _context.Foods.AddAsync(food);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Food>> GetAllAsync()
        {
            var result = await _context.Foods.ToListAsync();
            return result;
        }

        public async Task<Food> GetByIdAsync(int id)
        {
            var result = await _context.Foods.FirstOrDefaultAsync(n => n.FoodId == id);
            return result;
        }

        public Food Update(int id, Food updatedFood)
        {
            throw new NotImplementedException();
        }
    }
}
