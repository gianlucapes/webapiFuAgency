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
        public string GetById(int id)
        {
            return "Dipartimento Id : " + id;
        }
        [HttpGet("{nome:minlength(3):maxlength(20):alpha}")]
        public string GetByNomeDipartimento(string nome)
        {

            return "Dipartimento nome : " + nome;
        }
    }
}
