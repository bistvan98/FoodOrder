using FoodOrder.Models;

namespace FoodOrder.Data.Services
{
    public interface IFoodService
    {
        Task<IEnumerable<Food>> GetAllAsync();
        Task<Food> GetByIdAsync(int id);
        Task AddAsync(Food food);
        Food Update(int  id, Food updatedFood);
        void Delete(int id);
    }
}
