using Employee.Models;
using Employee.Repository;
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


  }
}
