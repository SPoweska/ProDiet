using System.Collections.Generic;
using System.Threading.Tasks;
using ProDiet.Data.Models;

namespace ProDiet.Services
{
    public interface IAlergeneStoresService
    {
        public Task<List<Alergene>> GetAllProductAlergenes(int productId);

        public List<Alergene> ReturnListAddedAlergenes(IEnumerable<string> alergenesList);
        //public Task AddAlergene(Alergene alergene, int productId);
        public Task UpdateAlergene(Alergene alergene);
        public Task DeleteAlergene(int alergeneId);
    }
}
