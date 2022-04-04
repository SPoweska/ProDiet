using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProDiet.Data;
using ProDiet.Migrations;
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

        public async Task<List<Patient>> GetAllPatients()
        {
            try
            {
                List<Patient> patients = await db.Patients.AsNoTracking().ToListAsync();
                return patients;
            }
            catch
            {
                Exception ex = new Exception("Error while loading patients");
                throw ex;
            }
        }

        public async Task<List<Patient>> GetAllUsersPatients(string UserId)
        {
            try
            {
                List<Patient> patients = await db.Patients.Where(x => x.CreatedBy == UserId).AsNoTracking().ToListAsync();
                return patients;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public async Task AddPatient(Patient patient)
        {
            try
            {
                await db.Patients.AddAsync(patient);
                await db.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                //Exception ex = new Exception("Error while adding patient");
                throw ex;
            }
        }

        public async Task UpdatePatient(Patient patient)
        {
            try
            {
                db.Entry(patient).State = EntityState.Modified;
                foreach (var bodyMeasurement in patient.BodyMeasurements)
                {
                    if (bodyMeasurement.MeasurementId != 0)
                    {
                        db.Entry(bodyMeasurement).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(bodyMeasurement).State = EntityState.Added;

                    }

                }

                var idsOfBodyMeasurements = patient.BodyMeasurements.Select(x => x.MeasurementId).ToList();
                var measurementsToDelete = await db.BodyMeasurements.
                    Where(x => !idsOfBodyMeasurements.
                        Contains(x.MeasurementId) && x.PatientId == patient.Id).ToListAsync();

                db.RemoveRange(measurementsToDelete);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //public async Task DeletePatient(int id)
        //{
        //    try
        //    {
        //       Patient? patient = db.Patients.FirstOrDefault(x => x.Id == id);

        //        if (patient != null)
        //        {
        //            db.Patients.Remove(patient);
        //        }
        //        await db.SaveChangesAsync();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public async Task DeletePatient(int id)
        {
            try
            {
                Patient? patient = await db.Patients.FirstOrDefaultAsync(x => x.Id == id);

                if (patient != null)
                {
                    db.Patients.Remove(patient);
                }
                await db.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
        }



        public async Task<Patient> GetPatientData(int id)
        {
            try
            {
                Patient? patient = await db.Patients.Include(x => x.BodyMeasurements).FirstOrDefaultAsync(x => x.Id == id);

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
            catch (Exception ex)
            {

                throw ex;
            }
        }
        

        public async Task<bool> CheckOwner(string ownerId, int patientId)
        {
            try
            {
                Patient? patient = await db.Patients.FirstAsync(x => x.Id == patientId);

                if (patient.CreatedBy!=ownerId)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
    }
}

