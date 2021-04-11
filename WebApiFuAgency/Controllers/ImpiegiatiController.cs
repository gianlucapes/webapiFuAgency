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
        private readonly ImpiegatiRepository _impiegatiRepository;

        public ImpiegiatiController()
        {
            _impiegatiRepository = new ImpiegatiRepository();
        }
      
        [HttpGet]
        public ActionResult GetAllImpiegati()
        {
            var impiegati = _impiegatiRepository.GetAllImpiegati();
            return Ok(impiegati);
        }

        [HttpGet("{entrepriseId:length(10):regex(entr(id|pr))}")]
        public ActionResult GetImpiegatiByEntrepriseId(string entrepriseId)
        {
            //mocke per verficare le funzioni
            var impiegato = new List<ImpiegatoModel>()
            {
               new ImpiegatoModel { Id = 1,EntrepriseId = entrepriseId,Nome = "Nome Di prova",Cognome = "oktagon"}
            };
            if (impiegato != null)
                return Ok(impiegato);
            else return NotFound($"Non è stato trovato nessun impiegato con {entrepriseId}");
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
       
        [HttpPost("")]
        public ActionResult AddImpiegato([FromBody] ImpiegatoModel impiegato)
        {
            _impiegatiRepository.AddImpiegato(impiegato);

            var impiegati = _impiegatiRepository.GetAllImpiegati();

            return Ok(impiegati);
        }
    }
}
