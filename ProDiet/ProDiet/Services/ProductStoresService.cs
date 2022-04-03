using Microsoft.EntityFrameworkCore;
using ProDiet.Data;
using ProDiet.Models;

namespace ProDiet.Services
{
    public class ProductStoresService : IProductStoresService
    {
        private ProDietContext db;

        public ProductStoresService(ProDietContext _db)
        {
            db = _db;
        }

        public async Task AddProduct(Product product)
        {
            try
            {
                await db.Products.AddAsync(product);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                //Exception ex = new Exception("Error while adding patient");
                throw ex;
            }
        }

        public async Task<bool> CheckOwner(string ownerId, int productId)
        {
            try
            {
                Product? product = await db.Products.FirstAsync(x => x.ProductId == productId);

                if (product.CreatedBy != ownerId)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async  Task<int> CountAllUsersProducts(string UserId)
        {
            try
            {
                int count = await db.Products.CountAsync(x => x.CreatedBy == UserId);
                return count;

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                Product? product =db.Products.FirstOrDefault(x => x.ProductId == id);

                if (product != null)
                {
                    db.Products.Remove(product);
                }
                db.SaveChanges();
            }

            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<List<Product>> GetAllProducts()
        {
            try
            {
                List<Product> products = await db.Products.AsNoTracking().ToListAsync();
                return products;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Product>> GetAllUsersProducts(string UserId)
        {
            try
            {
                List<Product> products = await db.Products.Where(x => x.CreatedBy == UserId).ToListAsync();
                return products;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Product> GetProductData(int id)
        {
            try
            {
                Product? product = await db.Products.Include(x=>x.Alergenes).Include(x=>x.Nutrients).Include(x=>x.HomeMeasurement).FirstOrDefaultAsync(x => x.ProductId == id);

                if (product != null)
                {
                    db.Entry(product).State = EntityState.Detached;
                    return product;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task UpdateProduct(Product product)
        {
            try
            {
                db.Entry(product).State =EntityState.Modified;

                foreach (var measturement in product.HomeMeasurement)
                {
                    if(measturement.MeasurementId != 0) 
                    {
                        db.Entry(measturement).State = EntityState.Modified; 
                    }
                    else
                    {
                        db.Entry(measturement).State = EntityState.Added;

                    }

                }

                foreach (var alergene in product.Alergenes)
                {
                    if (alergene.AlergeneId != 0)
                    {
                        db.Entry(alergene).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(alergene).State = EntityState.Added;

                    }
                }

                foreach (var nutrient in product.Nutrients)
                {
                    if (nutrient.NutrientId != 0)
                    {
                        db.Entry(nutrient).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(nutrient).State = EntityState.Added;

                    }
                }

                var idsOfMeasurements = product.HomeMeasurement.Select(x => x.MeasurementId).ToList();
                var measurementsToDelete = await db.HomeMeasurements.
                    Where(x => !idsOfMeasurements.
                    Contains(x.MeasurementId) && x.ProductId==product.ProductId).ToListAsync();

                db.RemoveRange(measurementsToDelete);

                var idsOfAlergenes = product.Alergenes.Select(x => x.AlergeneId).ToList();
                var alergenesToDelete = await db.Alergenes.
                    Where(x => !idsOfAlergenes.
                    Contains(x.AlergeneId) && x.ProductId == product.ProductId).ToListAsync();

                db.RemoveRange(alergenesToDelete);

                var idsOfNutrients = product.Nutrients.Select(x => x.NutrientId).ToList();
                var nutrientsToDelete = await db.Nutrients.
                    Where(x => !idsOfNutrients.
                    Contains(x.NutrientId) && x.ProductId == product.ProductId).ToListAsync();

                db.RemoveRange(nutrientsToDelete);


                await db.SaveChangesAsync();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
