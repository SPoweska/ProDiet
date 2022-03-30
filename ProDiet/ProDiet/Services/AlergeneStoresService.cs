using System.Collections;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;
using ProDiet.Data;
using ProDiet.Data.Models;

namespace ProDiet.Services
{
    public class AlergeneStoresService : IAlergeneStoresService
    {

        private ProDietContext db;

        public AlergeneStoresService(ProDietContext _db)
        {
            db = _db;
        }

        //public async Task AddAlergene(Alergene alergene, int productId)
        //{
        //    try
        //    {
        //        await db.Alergenes.AddAsync(alergene);
        //        await db.SaveChangesAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Exception ex = new Exception("Error while adding patient");
        //        throw ex;
        //    }
        //}

        public List<Alergene> ReturnListAddedAlergenes(IEnumerable<string> alergenesList)
        {
            if(alergenesList.Any())
            {

                List<Alergene> filledListAlergenes = new List<Alergene>();
                foreach (string alergen in alergenesList)
                {
                    Alergene aler = new Alergene();
                    aler.AlergeneName=alergen;
                    filledListAlergenes.Add(aler);

                }

                return filledListAlergenes;
            }
            else
            {
                List<Alergene> emptyList=new List<Alergene>();
                return emptyList;
            }
        }

        public async Task DeleteAlergene(int alergeneId)
        {
            try
            {
                Alergene? alergene = await db.Alergenes.FirstOrDefaultAsync(x => x.AlergeneId == alergeneId);

                if (alergene != null)
                {
                    db.Alergenes.Remove(alergene);
                }
                await db.SaveChangesAsync();
            }

            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<List<Alergene>> GetAllProductAlergenes(int productId)
        {
            try
            {
                List<Alergene> alergenes = await db.Alergenes.AsNoTracking().Where(x=>x.ProductId== productId).ToListAsync();
                return alergenes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task UpdateAlergene(Alergene alergene)
        {
            try
            {
                db.Entry(alergene).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
