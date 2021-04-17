using Employee.Entity;
using Employee.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Repository
{
 public interface IDipartimentiRepository
    {
        public Task<List<DipartimentoModel>> GetDipartimentiByGeoCode(int geoCode);

        public Task<List<DipartimentoModel>> GetDipartimentiByNome(string nome);

        public Task<List<DipartimentoModel>> GetDipartimentiByLuogo(string luogo);

        public Task<List<DipartimentoModel>> GetAllDipartimenti();

        public Task AddDipartimento(DipartimentoModel dipartimentiModel);

        public Task UpdateDipartimento(int geoCode, JsonPatchDocument dipartimentiModel);

        public Task DeleteImpiegato(int geoCode);


    }
}
