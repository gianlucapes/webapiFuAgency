using Employee.Models;
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
        [HttpGet]
        public string GetAllImpiegati()
        {
            return "all impiegati";
        }

        [HttpGet("{entrepriseId:length(10):regex(entr(id|pr))}")]
        public ActionResult GetImpiegatiByEntrepriseId(string entrepriseId)
        {
            //mocke per verficare le funzioni
            var impiegato = new List<ImpiegatoModel>()
            {
               new ImpiegatoModel { Id = 1,EntrepriseId = entrepriseId,Nome = "Nome Di prova",Cognome = "oktagon"}
            };
            return Ok(impiegato);
        }
        [HttpGet("GetImpiegatiByNome/{nome}")]
        public string GetImpiegatoByNome(string nome)
        {
            return "Impiegato :"+nome;
        }
        [HttpGet("SearcheImpiegato")]
        public string SearcheImpiegato(string entId,string nome,string qualifica,string telefono)
        {
            return "Scheda dell'impiegato";
        }
    }
}
