using ProDiet.Models;

namespace ProDiet.Services
{
    public interface IUsedProductStoresService
    {
        public Task<List<UsedProduct>> GetAllDishProducts(int DishId);
        public Task AddUsedProduct(UsedProduct usedProduct);
        public Task UpdateUsedProduct(UsedProduct usedProduct);
        public Task DeleteUsedProduct(int id);
        public Task<UsedProduct> GetUsedProductData(int id);
    }
}
