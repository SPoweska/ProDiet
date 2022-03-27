using ProDiet.Models;

namespace ProDiet.Services
{
    public interface IProductStoresService
    {

        public Task<List<Product>>  GetAllProducts();
        public Task<List<Product>> GetAllUsersProducts(string UserId);
        public Task<int> CountAllUsersProducts(string UserId);
        public Task AddProduct(Product product);
        public Task UpdateProduct(Product product);
        public void DeleteProduct(int id);
        public Task<Product> GetProductData(int id);
        public Task<bool> CheckOwner(string ownerId, int productId);
    }
}
