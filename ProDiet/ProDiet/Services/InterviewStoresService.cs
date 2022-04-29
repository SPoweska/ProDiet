using Microsoft.EntityFrameworkCore;
using ProDiet.Data;
using ProDiet.Models;

namespace ProDiet.Services
{
    public class InterviewStoresService : IInterviewStoresService
    {
        private ProDietContext db;

        public InterviewStoresService(ProDietContext _db)
        {
            db = _db;
        }

        public async Task AddInterview(Interview interview)
        {
            
        }

        public async Task UpdateInterview(Interview interview)
        {
            if (interview != null)
            {
                try
                {
                    db.Entry(interview).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task<Interview> GetInterviewData(int patientId)
        {
            try
            {
                Interview? interview = await db.Interviews.FirstOrDefaultAsync(x => x.PatientId == patientId);

                if (interview != null)
                {
                    db.Entry(interview).State = EntityState.Detached;
                    return interview;
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
    }
}
