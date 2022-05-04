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


    }
}
