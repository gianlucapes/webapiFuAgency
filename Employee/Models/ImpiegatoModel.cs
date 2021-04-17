using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Employee.Entity;

namespace Employee.Models
{
   
   public class ImpiegatoModel
    {
        
        [Required]
       public int EntrepriseId { get; set; }
        [Required]
       public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [Required]
        public string Qualifica { get; set; }
        public string Telefono { get; set; }

        public string ImmagineProfilo { get; set; }
        [Required]
        public int RackingPoints { get; set; }

        public int Dipartimento { get; set; }
    }
}
