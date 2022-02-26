using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProDiet.Data;
using ProDiet.Models;

namespace ProDiet.Services
{
    public class PatientStoresService:IPatientStoresService
    {
        private ProDietContext db;

        public PatientStoresService(ProDietContext _db)
        {
            db = _db;
        }

        public List<Patient> GetAllPatients()
        {
            try
            {
                return db.Patients.AsNoTracking().ToList();
            }
            catch
            {
                Exception ex = new Exception("Error while loading patients");
                throw ex;
            }
        }

        public List<Patient> GetAllUsersPatients(string UserId)
        {
            try
            {
                return db.Patients.Where(x => x.CreatedBy == UserId).AsNoTracking().ToList();
            }
            catch
            {
                Exception ex = new Exception("Error while loading patients");
                throw ex;
            }
        }

        public void AddPatient(Patient patient)
        {
            try
            {
                //patient.CreatedBy = id;
                //patient.CreatedAt = DateTime.Now;
                db.Patients.Add(patient);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                //Exception ex = new Exception("Error while adding patient");
                throw ex;
            }
        }

        public void UpdatePatient(Patient patient)
        {
            try
            {
                //patient.CreatedBy = id;
                //patient.CreatedAt = DateTime.Now; //do zrobienia
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                Exception ex = new Exception("Error while editing patient");
                throw ex;
            }
        }

        public async void DeletePatient(int id)
        {
            try
            {
               Patient? patient = await db.Patients.FirstOrDefaultAsync(x => x.Id == id);

                if (patient != null)
                {
                    db.Patients.Remove(patient);
                }
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Patient> GetPatientData(int id)
        {
            try
            {
                Patient? patient = await db.Patients.FirstOrDefaultAsync(x=>x.Id==id);

                if (patient != null)
                {
                    db.Entry(patient).State = EntityState.Detached;
                    return patient;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

