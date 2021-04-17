using Employee.Data;
using Employee.Entity;
using Employee.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Repository.impl
{
    public class DipartimentiRepository : IDipartimentiRepository
    {
        private readonly RolmexContext _rolmexContext;

        public DipartimentiRepository(RolmexContext rolmexContext)
        {
            this._rolmexContext = rolmexContext;
        }
        public async Task AddDipartimento(DipartimentoModel dipartimentiModel)
        {
            var dipartimento = new Dipartimenti()
            {
                GeoCode = dipartimentiModel.GeoCode,
                Nome = dipartimentiModel.Nome,
                Luogo = dipartimentiModel.Luogo,
                Descrizione = dipartimentiModel.Luogo,
                ImmagineDipartimento = dipartimentiModel.ImmagineDipartimento,
                Leader = dipartimentiModel.Leader
            };
            await _rolmexContext.Dipartimenti.AddAsync(dipartimento);
            _rolmexContext.SaveChanges();
        }

        public async Task DeleteImpiegato(int geoCode)
        {
            var dipartimento = new Dipartimenti() { GeoCode = geoCode };
            _rolmexContext.Dipartimenti.Remove(dipartimento);
            await _rolmexContext.SaveChangesAsync();

        }

        public async Task<List<DipartimentoModel>> GetAllDipartimenti()
        {
            var records = await _rolmexContext.Dipartimenti.Select(x => new DipartimentoModel()
            {
              GeoCode = x.GeoCode,
              Nome = x.Nome,
              Luogo = x.Luogo,
              Descrizione = x.Descrizione,
              ImmagineDipartimento = x.ImmagineDipartimento,
              Leader=x.Leader
            }).ToListAsync();

            return records;
        }

        public async Task<List<DipartimentoModel>> GetDipartimentiByGeoCode(int geoCode)
        {
            var records = await _rolmexContext.Dipartimenti.Where(x => x.GeoCode == geoCode).Select(x => new DipartimentoModel()
            {
                GeoCode = x.GeoCode,
                Nome = x.Nome,
                Luogo = x.Luogo,
                Descrizione = x.Descrizione,
                ImmagineDipartimento = x.ImmagineDipartimento,
                Leader = x.Leader
            }).ToListAsync();

            return records;
        }

        public async Task<List<DipartimentoModel>> GetDipartimentiByLuogo(string luogo)
        {
            var records = await _rolmexContext.Dipartimenti.Where(x => x.Luogo == luogo).Select(x => new DipartimentoModel()
            {
                GeoCode = x.GeoCode,
                Nome = x.Nome,
                Luogo = x.Luogo,
                Descrizione = x.Descrizione,
                ImmagineDipartimento = x.ImmagineDipartimento,
                Leader = x.Leader
            }).ToListAsync();

            return records;
        }

        public async Task<List<DipartimentoModel>> GetDipartimentiByNome(string nome)
        {
            var records = await _rolmexContext.Dipartimenti.Where(x => x.Nome == nome).Select(x => new DipartimentoModel()
            {
                GeoCode = x.GeoCode,
                Nome = x.Nome,
                Luogo = x.Luogo,
                Descrizione = x.Descrizione,
                ImmagineDipartimento = x.ImmagineDipartimento,
                Leader = x.Leader
            }).ToListAsync();

            return records;
        }

        public Task UpdateDipartimento(int geoCode, JsonPatchDocument dipartimentiModel)
        {
            throw new NotImplementedException();
        }
    }
}
