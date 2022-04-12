using ProDiet.Models;

namespace ProDiet.Services
{
    public interface IInterviewStoresService
    {
        public Task AddInterview(Interview interview);
        public Task UpdateInterview(Interview interview);
        public Task<Interview> GetInterviewData(int patientId);
    }
}
