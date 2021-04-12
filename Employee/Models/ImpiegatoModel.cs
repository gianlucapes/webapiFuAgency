using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Models
{
   
   public class ImpiegatoModel
    {

       public int EntrepriseId { get; set; }

       public string Nome { get; set; }

       public string Cognome { get; set; }

        public string Qualifica { get; set; }

        public string Telefono { get; set; }

        public int RackingPoints { get; set; }
    }
}
