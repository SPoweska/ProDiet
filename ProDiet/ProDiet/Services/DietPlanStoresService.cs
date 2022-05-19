using System.Linq;
using System.Security.Cryptography.Pkcs;
using Microsoft.EntityFrameworkCore;
using ProDiet.Data;
using ProDiet.Models;
using ProDiet.Models.DietPlan;

namespace ProDiet.Services
{
    public class DietPlanStoresService: IDietPlanStoresService
    {
        private ProDietContext db;

        public DietPlanStoresService(ProDietContext _db)
        {
            db = _db;
        }

        public async Task<List<DietPlan>> GetAllPatientDietPlans(int patientId)
        {
            try
            {
                List<DietPlan> dietPlans = await db.DietPlans.AsNoTracking().Where(x => x.PatientId == patientId).ToListAsync();

                if (dietPlans != null)
                {
                    return dietPlans;
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

        public async Task<DietPlan> GetDietPlan(int dietPlanId)
        {
            try
            {
                DietPlan? dietPlan = await db.DietPlans.Include(x => x.DietPlanDays).FirstOrDefaultAsync(x => x.DietPlanId == dietPlanId);

                if (dietPlan != null)
                {
                    //db.Entry(dish).State = EntityState.Detached;
                    return dietPlan;
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

        public async Task<DietPlan> GetDietPlanSummary(int dietPlanId)
        {
            try
            {
                DietPlan? dietPlan = await db.DietPlans.Include(x => x.DietPlanDays).ThenInclude(x=>x.DietPlanDayMeals).ThenInclude(x=>x.MealDish).ThenInclude(x=>x.Dish).ThenInclude(x=>x.UsedProducts).ThenInclude(x=>x.Product).FirstOrDefaultAsync(x => x.DietPlanId == dietPlanId);

                if (dietPlan != null)
                {
                    //db.Entry(dish).State = EntityState.Detached;
                    return dietPlan;
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

        public async Task AddDietPlan(DietPlan dietPlan)
        {
            try
            {
                
                await db.DietPlans.AddAsync(dietPlan);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateDietPlan(DietPlan dietPlan)
        {
            try
            {
                db.Entry(dietPlan).State = EntityState.Modified;

                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task DeleteDietPlan(int dietPlanId)
        {
            try
            {
                DietPlan? dietPlan = await db.DietPlans.FirstOrDefaultAsync(x => x.DietPlanId == dietPlanId);

                if (dietPlan != null)
                {
                    db.DietPlans.Remove(dietPlan);
                }
                await db.SaveChangesAsync();
            }

            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<DietPlanDay> GetDietPlanDay(int dietPlanDayId)
        {
            try
            {
                DietPlanDay dietPlanDay =
                    await db.DietPlanDays.Include(x=>x.DietPlanDayMeals).ThenInclude(x => x.MealDish).ThenInclude(x => x.Dish).FirstOrDefaultAsync(x => x.DietPlanDayId == dietPlanDayId);

                if (dietPlanDay != null)
                {
                    //db.Entry(dish).State = EntityState.Detached;
                    return dietPlanDay;
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

        public async Task UpdateDietPlanDay(DietPlanDay dietPlanDay)
        {
            try
            {
                db.Entry(dietPlanDay).State = EntityState.Modified;

                foreach (var meal in dietPlanDay.DietPlanDayMeals)
                {
                    if (meal.Name == null)
                    {
                        meal.Name = "Posiłek";
                    }
                    
                    meal.CreatedAt = DateTime.Now;
                    meal.CreatedBy = dietPlanDay.CreatedBy;

                }
                foreach (var DayMeal in dietPlanDay.DietPlanDayMeals)
                {
                    if (DayMeal.MealId != 0)
                    {
                        db.Entry(DayMeal).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(DayMeal).State = EntityState.Added;
                    }


                }
                var idsOfDayMeals = dietPlanDay.DietPlanDayMeals.Select(x => x.DietPlanDayId).ToList();
                var dayMealsToDelete = await db.MealDishes.
                    Where(x => !idsOfDayMeals.
                        Contains(x.MealId) && x.MealId == dietPlanDay.DietPlanDayId).ToListAsync();

                db.RemoveRange(dayMealsToDelete);


                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<DayMeal> GetDayMeal(int mealId)
        {
            try
            {
                DayMeal DayMeal =
                    await db.DayMeals.Include(x => x.MealDish).ThenInclude(x=>x.Dish).ThenInclude(x=>x.UsedProducts).ThenInclude(x=>x.Product).FirstOrDefaultAsync(x => x.MealId == mealId);

                if (DayMeal != null)
                {
                    //db.Entry(dish).State = EntityState.Detached;
                    return DayMeal;
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

        public async Task<DayMeal> UpdateDayMeal(DayMeal dayMeal)
        {
            try
            {
                if (dayMeal.MealId == 0)
                {
                    db.Entry(dayMeal).State = EntityState.Added;
                }
                else
                {
                    db.Entry(dayMeal).State = EntityState.Modified;
                }

                await db.SaveChangesAsync();
                return dayMeal;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<int> UpdateMealDish(MealDish mealDish)
        {
            try
            {
                if (mealDish.MealDishId != 0)
                {
                    db.Entry(mealDish).State = EntityState.Modified;
                }
                else
                {
                    db.Entry(mealDish).State = EntityState.Added;

                }

                await db.SaveChangesAsync();
                return mealDish.MealDishId;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        
    }
}
