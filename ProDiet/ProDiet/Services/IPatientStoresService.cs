using ProDiet.Models;

namespace ProDiet.Services
{
    public interface IPatientStoresService
    {
        public Task<List<Patient>>  GetAllPatients();
        public Task<List<Patient>> GetAllUsersPatients(string UserId);
        public Task AddPatient(Patient patient);
        public Task UpdatePatient(Patient patient);
        //public Task DeletePatient(int id);
        public void DeletePatient(int id);
        public Task<Patient> GetPatientData(int id);
        public Task<bool> CheckOwner(string ownerId, int patientId);


    }
}
