using Employee.Data;
using Employee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Repository
{
    public class ImpiegatiRepository : IImpiegatiRepository
    {

        private readonly ImpiegatiContext _impiegatiContext;
        public ImpiegatiRepository(ImpiegatiContext impiegatiContext)
        {
            this._impiegatiContext = impiegatiContext;
        }
        public async Task<List<ImpiegatoModel>> GetAllImpiegati()
        {
            var records = await _impiegatiContext.Impiegato.Select(x => new ImpiegatoModel()
                 {
                EntrepriseId = x.EntrepriseId,
                Nome = x.Nome,
                Cognome = x.Cognome,
                Qualifica = x.Qualifica,
                Telefono = x.Telefono,
                RackingPoints = x.RakingPoints,
                 }).ToListAsync();

            return records;
        }
        public int AddImpiegato(ImpiegatoModel impiegato)
        {
           
            return impiegato.EntrepriseId;
        }
      

        public ImpiegatoModel GetImpiegatoByNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
