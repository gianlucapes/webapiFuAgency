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
        [HttpGet("{id:int:min(1)}")]
        public ActionResult GetById(int id)
        {
            return NotFound("Non ancora implementato");
        }
        [HttpGet("{nome:minlength(3):maxlength(20):alpha}")]
        public ActionResult GetByNomeDipartimento(string nome)
        {

            return NotFound("Non ancora implementato");
        }
        public ActionResult GetByGeoCode(string geocode)
        {
            return Unauthorized();
        }
    }
}
