using ProDiet.Models;

namespace ProDiet.Services
{
    public interface IDishStoresService
    {
        public Task<List<Dish>> GetAllDishes();
        public Task<List<Dish>> GetAllUserDishes(string userId);
        public Task AddDish(Dish dish);
        public Task UpdateDish(Dish dish);
        public Task DeleteDish(int dishId);
        public Task<Dish> GetDish(int dishId);
        public Task<int> AddDishReturnId(Dish dish);
    }
}
