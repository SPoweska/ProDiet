using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProDiet.Data;
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
                DietPlan? dietPlan = await db.DietPlans.Include(x => x.DietPlanDays).Include(x=>x.Meals).FirstOrDefaultAsync(x => x.DietPlanId == dietPlanId);

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

                foreach (var meal in dietPlan.Meals)
                {
                    if (meal.MealId != 0)
                    {
                        db.Entry(meal).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(meal).State = EntityState.Added;

                    }

                }
                var idsOfMeals = dietPlan.Meals.Select(x => x.MealId).ToList();
                var mealsToDelete = await db.Meals.
                    Where(x => !idsOfMeals.
                        Contains(x.MealId) && x.DietPlanId == dietPlan.DietPlanId).ToListAsync();

                db.RemoveRange(mealsToDelete);
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

        public async Task UpdateDietPlanDay(DietPlanDay dietPlanDay)
        {
            try
            {
                db.Entry(dietPlanDay).State = EntityState.Modified;

                foreach (var dietPlanDish in dietPlanDay.DietPlanDayDish)
                {
                    if (dietPlanDish.DayDishId != 0)
                    {
                        db.Entry(dietPlanDish).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(dietPlanDish).State = EntityState.Added;

                    }

                }
                var idsOfDayDishes = dietPlanDay.DietPlanDayDish.Select(x => x.DayDishId).ToList();
                var dayDishesToDelete = await db.DietPlanDayDishes.
                    Where(x => !idsOfDayDishes.
                        Contains(x.DayDishId) && x.DietPlanDayId == dietPlanDay.DietPlanDayId).ToListAsync();

                db.RemoveRange(dayDishesToDelete);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
