﻿using Employee.Data;
using Employee.Entity;
using Employee.Models;
using Microsoft.AspNetCore.JsonPatch;
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

        private readonly RolmexContext _rolmexContext;
        public ImpiegatiRepository(RolmexContext rolmexContext)
        {
            this._rolmexContext = rolmexContext;
        }

        public async Task<int> AddImpiegato(ImpiegatoModel impiegato)
        {
            var _impiegato = new Impiegato() 
            { 
             Nome = impiegato.Nome,
             Cognome = impiegato.Cognome,
             Qualifica= impiegato.Qualifica,
             RakingPoints = impiegato.RackingPoints,
             ImmagineProfilo = impiegato.ImmagineProfilo,
             Telefono = impiegato.Telefono,
             Dipartimento = impiegato.Dipartimento
            };

            _rolmexContext.Impiegato.Add(_impiegato);
           await _rolmexContext.SaveChangesAsync();
            return impiegato.EntrepriseId;
        }

        public async Task DeleteImpiegato(int EntrPrs)
        {
            var impiegato = new Impiegato() { EntrepriseId = EntrPrs};
            _rolmexContext.Remove(impiegato);
            await _rolmexContext.SaveChangesAsync();
        }

        public async Task<List<ImpiegatoModel>> GetAllImpiegati()
        {
            var records = await _rolmexContext.Impiegato.Select(x => new ImpiegatoModel()
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
            var records = await _rolmexContext.Impiegato.Where(x => x.EntrepriseId == entrId).Select(x => new ImpiegatoModel()
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

        public async Task UpdateAllImpiegato(int entrId, ImpiegatoModel impiegatoModel)
        {
            var _impiegato = new Impiegato()
            {
                EntrepriseId = entrId,
                Nome = impiegatoModel.Nome,
                Cognome = impiegatoModel.Cognome,
                Qualifica = impiegatoModel.Qualifica,
                RakingPoints = impiegatoModel.RackingPoints,
                Telefono = impiegatoModel.Telefono
            };

            _rolmexContext.Impiegato.Update(_impiegato);
            await _rolmexContext.SaveChangesAsync();
         

        }

        public async Task UpdateImpiegato(int entrId, JsonPatchDocument impiegatoModel)
        {
            var impiegato = await _rolmexContext.Impiegato.FindAsync(entrId);

            if(impiegato != null)
            {
                impiegatoModel.ApplyTo(impiegato);
                await _rolmexContext.SaveChangesAsync();
            }

        }
    }
}
