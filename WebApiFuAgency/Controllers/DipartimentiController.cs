using Employee.Models;
using Employee.Repository;
using Employee.Repository.impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFuAgency.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DipartimentiController : ControllerBase
    {
        private readonly IDipartimentiRepository _dipartimentiRepository;
        public DipartimentiController(IDipartimentiRepository dipartimentiRepository)
        {
            this._dipartimentiRepository = dipartimentiRepository;
        }
        [HttpPost("")]
        public async Task<IActionResult> AddDipartimenti([FromBody]DipartimentoModel dipartimentiModel)
        {
           await _dipartimentiRepository.AddDipartimento(dipartimentiModel);
            return Ok(dipartimentiModel.Nome);

        }
        [HttpGet("")]
        public async Task<IActionResult> GetAllDipartimenti()
        {
         var dipartimenti = await _dipartimentiRepository.GetAllDipartimenti();
            return Ok(dipartimenti);
        }

        [HttpGet("{geoCode}")]
        public async Task<IActionResult> GetDipartimentoByGeoCode([FromRoute]int geoCode)
        {
            var dipartimento = await _dipartimentiRepository.GetDipartimentiByGeoCode(geoCode);
            return Ok(dipartimento);
        }
        [HttpGet("{luogo}")]
        public async Task<IActionResult> GetDipartimentoLuogo([FromRoute] string luogo)
        {
            var dipartimento = await _dipartimentiRepository.GetDipartimentiByLuogo(luogo);
            return Ok(dipartimento);
        }
    }
}
