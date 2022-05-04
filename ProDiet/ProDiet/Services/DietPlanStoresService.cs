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
                    await db.DietPlanDays.Include(x=>x.DietPlanDayMeals).FirstOrDefaultAsync(x => x.DietPlanDayId == dietPlanDayId);

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

                foreach (var dietPlanDayMeal in dietPlanDay.DietPlanDayMeals)
                {
                    if (dietPlanDayMeal.DietPlanDayId != 0)
                    {
                        db.Entry(dietPlanDayMeal).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(dietPlanDayMeal).State = EntityState.Added;

                    }

                }
                var idsOfDayMeals = dietPlanDay.DietPlanDayMeals.Select(x => x.DietPlanDayId).ToList();
                var dayMealsToDelete = await db.DietPlanDayDishes.
                    Where(x => !idsOfDayMeals.
                        Contains(x.DayMealId) && x.DayMealId == dietPlanDay.DietPlanDayId).ToListAsync();

                db.RemoveRange(dayMealsToDelete);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<DayMeal> GetDietPlanDayMeal(int mealId)
        {
            try
            {
                DayMeal dietPlanDayMeal =
                    await db.DayMeals.Include(x => x.MealDish).FirstOrDefaultAsync(x => x.MealId == mealId);

                if (dietPlanDayMeal != null)
                {
                    //db.Entry(dish).State = EntityState.Detached;
                    return dietPlanDayMeal;
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

        public async Task UpdateDietPlanDayMeal(DayMeal dayMeal)
        {
            try
            {
                     if (dayMeal.MealId != 0)
                    {
                        db.Entry(dayMeal).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(dayMeal).State = EntityState.Added;
                    }
                     await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
