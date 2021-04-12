using Employee.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Repository
{
    public interface IImpiegatiRepository
    {
        int AddImpiegato(ImpiegatoModel impiegato);
        public Task<List<ImpiegatoModel>> GetAllImpiegati();

        ImpiegatoModel GetImpiegatoByNome(string nome);
    }
}