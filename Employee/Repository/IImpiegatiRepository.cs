using Employee.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Repository
{
    public interface IImpiegatiRepository
    {
        public Task<List<ImpiegatoModel>> GetAllImpiegati();

        public Task<ImpiegatoModel> GetImpiegatoByEntrId(int entrId);

        public Task<int> AddImpiegato(ImpiegatoModel impiegato);

        public Task UpdateImpiegato(int entrId, ImpiegatoModel impiegatoModel);
    }
}