using ProDiet.Models.DietPlan;

namespace ProDiet.Services
{
    public interface IDietPlanStoresService
    {
        
        public Task<List<DietPlan>> GetAllPatientDietPlans(int patientId);
        public Task<DietPlan> GetDietPlan(int dietPlanId);
        public Task AddDietPlan(DietPlan dietPlan);
        public Task UpdateDietPlan(DietPlan dietPlan);
        public Task DeleteDietPlan(int dietPlanId);
        public Task UpdateDietPlanDay(DietPlanDay dietPlanDay);
        public Task<DietPlanDay> GetDietPlanDay(int dietPlanDayId);
        public Task<DayMeal> UpdateDayMeal(DayMeal dayMeal);
        public Task<DayMeal> GetDayMeal(int mealId);
        public Task<int> UpdateMealDish(MealDish mealDish);
        public Task<DietPlan> GetDietPlanSummary(int dietPlanId);


    }
}
