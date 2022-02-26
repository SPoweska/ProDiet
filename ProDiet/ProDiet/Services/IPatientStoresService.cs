using ProDiet.Models;

namespace ProDiet.Services
{
    public interface IPatientStoresService
    {
        public List<Patient> GetAllPatients();
        public List<Patient> GetAllUsersPatients(string UserId);
        public void AddPatient(Patient patient);
        public void UpdatePatient(Patient patient);
        public void DeletePatient(int id);
        public Task<Patient> GetPatientData(int id);

    }
}
