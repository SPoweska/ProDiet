using Microsoft.EntityFrameworkCore;
using ProDiet.Data;
using ProDiet.Models;

namespace ProDiet.Services
{
    public class DishStoresService : IDishStoresService
    {
        private ProDietContext db;

        public DishStoresService(ProDietContext _db)
        {
            db = _db;
        }

        public async Task AddDish(Dish dish)
        {
            try
            {
                await db.Dishes.AddAsync(dish);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                //Exception ex = new Exception("Error while adding patient");
                throw ex;
            }
        }

        public async Task DeleteDish(int dishId)
        {
            try
            {
                Dish? dish = await db.Dishes.FirstOrDefaultAsync(x => x.DishId == dishId);

                if (dish != null)
                {
                    db.Dishes.Remove(dish);
                }
                await db.SaveChangesAsync();
            }

            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<List<Dish>> GetAllDishes()
        {
            try
            {
                List<Dish> dishes = await db.Dishes.AsNoTracking().Include(x=>x.UsedProducts)
                    .ToListAsync();
                return dishes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Dish>> GetAllUserDishes(string userId)
        {
            try
            {
                List<Dish> dishes = await db.Dishes.AsNoTracking().Include(x=>x.UsedProducts).Where(x=>x.CreatedBy==userId).ToListAsync();

                if (dishes != null)
                {
                    return dishes;
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

        public async Task<Dish> GetDish(int dishId)
        {
            try
            {
                Dish? dish = await db.Dishes.Include(x=>x.UsedProducts).FirstOrDefaultAsync(x => x.DishId == dishId);

                if (dish != null)
                {
                    //db.Entry(dish).State = EntityState.Detached;
                    return dish;
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

        public async Task UpdateDish(Dish dish)
        {
            try
            {
                db.Entry(dish).State = EntityState.Modified;

                foreach (var usedProduct in dish.UsedProducts)
                {
                    if (usedProduct.UsedProductId != 0)
                    {
                        db.Entry(usedProduct).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(usedProduct).State = EntityState.Added;

                    }

                }
                var idsOfUsedProducts =  dish.UsedProducts.Select(x => x.UsedProductId).ToList();
                var usedProductsToDelete = await db.UsedProducts.
                    Where(x => !idsOfUsedProducts.
                        Contains(x.UsedProductId) && x.DishId == dish.DishId).ToListAsync();

                db.RemoveRange(usedProductsToDelete);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
