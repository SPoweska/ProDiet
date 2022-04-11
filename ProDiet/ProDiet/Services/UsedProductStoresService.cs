//using Microsoft.EntityFrameworkCore;
//using ProDiet.Data;
//using ProDiet.Migrations;
//using ProDiet.Models;

//namespace ProDiet.Services
//{
//    public class UsedProductStoresService : IUsedProductStoresService
//    {

//        private ProDietContext db;

//        public UsedProductStoresService(ProDietContext _db)
//        {
//            db = _db;
//        }

//        public async Task AddUsedProduct(UsedProduct usedProduct)
//        {
//            try
//            {
//                await db.UsedProducts.AddAsync(usedProduct);
//                await db.SaveChangesAsync();
//            }
//            catch (Exception ex)
//            {
//                //Exception ex = new Exception("Error while adding patient");
//                throw ex;
//            }
//        }

//        public async Task DeleteUsedProduct(int usedProductId)
//        {
//            try
//            {
//                UsedProduct? usedProduct = await db.UsedProducts.FirstOrDefaultAsync(x => x.UsedProductId == usedProductId);

//                if (usedProduct != null)
//                {
//                    db.UsedProducts.Remove(usedProduct);
//                }
//                await db.SaveChangesAsync();
//            }

//            catch (Exception e)
//            {

//                throw e;
//            }
//        }

//        public async Task<List<UsedProduct>> GetAllDishProducts(int DishId)
//        {
//            try
//            {
//                List<UsedProduct> usedProducts = await db.UsedProducts.Where(x=>x.DishId==DishId).AsNoTracking().ToListAsync();
//                return usedProducts;
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }
//        }


//        public async Task<UsedProduct> GetUsedProductData(int id)
//        {
//            try
//            {
//                UsedProduct? usedProduct = await db.UsedProducts.FirstOrDefaultAsync(x => x.ProductId == id);

//                if (usedProduct != null)
//                {
//                    //db.Entry(usedProduct).State = EntityState.Detached;
//                    return usedProduct;
//                }
//                else
//                {
//                    throw new ArgumentNullException();
//                }
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }
//        }

//        public async Task UpdateUsedProduct(UsedProduct usedProduct)
//        {
//            try
//            {
//                db.Entry(usedProduct).State = EntityState.Modified;
//                await db.SaveChangesAsync();
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }
//        }
//    }
//}
