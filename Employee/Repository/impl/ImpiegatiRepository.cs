using Employee.Data;
using Employee.Entity;
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

        public async Task<int> AddImpiegato(ImpiegatoModel impiegato)
        {
            var _impiegato = new Impiegato() 
            { 
             Nome = impiegato.Nome,
             Cognome = impiegato.Cognome,
             Qualifica= impiegato.Qualifica,
             RakingPoints = impiegato.RackingPoints,
             Telefono = impiegato.Telefono
            };

            _impiegatiContext.Impiegato.Add(_impiegato);
           await _impiegatiContext.SaveChangesAsync();
            return impiegato.EntrepriseId;
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

        public async Task<ImpiegatoModel> GetImpiegatoByEntrId(int entrId)
        {
            var records = await _impiegatiContext.Impiegato.Where(x => x.EntrepriseId == entrId).Select(x => new ImpiegatoModel()
            {
                EntrepriseId = x.EntrepriseId,
                Nome = x.Nome,
                Cognome = x.Cognome,
                Qualifica = x.Qualifica,
                Telefono = x.Telefono,
                RackingPoints = x.RakingPoints,
            }).FirstOrDefaultAsync();

            return records;
        }
    }
}
