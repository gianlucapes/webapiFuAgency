using Employee.Models;
using Employee.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFuAgency.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImpiegiatiController : ControllerBase
    {
        private readonly IImpiegatiRepository _impiegatiRepository;

        public ImpiegiatiController(IImpiegatiRepository impiegatiRepository)
        {
            _impiegatiRepository = impiegatiRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllImpiegati()
        {
            var impiegati = await _impiegatiRepository.GetAllImpiegati();
            return Ok(impiegati);
        }

        [HttpGet("{entrId}")]
        public async Task<IActionResult> GetImpiegatoByEntrId([FromRoute] int entrId)
        {
            var impiegato = await _impiegatiRepository.GetImpiegatoByEntrId(entrId);
            if (impiegato != null)
                return Ok(impiegato);
            else
                return Ok("Non è stato trovato nessun impiegato");
        }

        [HttpPost("")]
        public async Task<IActionResult> AddImpiegato([FromBody] ImpiegatoModel impiegatoModel)
        {
            var entrId = await _impiegatiRepository.AddImpiegato(impiegatoModel);
            return CreatedAtAction(nameof(GetImpiegatoByEntrId), new { entrId = entrId , controller = "Impiegiati" } , entrId);
            
        }

        [HttpPatch("{entrId}")]
        public async Task<IActionResult> UpdateImpiegato([FromRoute] int entrId,[FromBody] JsonPatchDocument impiegatoModel)
        {
             await _impiegatiRepository.UpdateImpiegato(entrId, impiegatoModel);
            return Ok(entrId);
        }


        [HttpDelete("{entrId}")]
        public async Task<IActionResult> UpdateImpiegato([FromRoute] int entrId)
        {
            await _impiegatiRepository.DeleteImpiegato(entrId);
            return Ok(entrId);

        }







    }
}
