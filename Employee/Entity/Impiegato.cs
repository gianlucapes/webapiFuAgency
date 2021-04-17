using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Employee.Entity
{
   
    public class Impiegato
   {
        [Key]
        public int EntrepriseId { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string Qualifica { get; set; }

        public string Telefono { get; set; }

        public int RakingPoints { get; set; }

        public string ImmagineProfilo { get; set; }

        public int Dipartimento { get; set; }
   }
}
