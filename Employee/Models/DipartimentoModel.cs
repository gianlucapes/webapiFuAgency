using Employee.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Models
{
   public class DipartimentoModel
    {
        public int GeoCode { get; set; }

        public string Nome { get; set; }

        public string Luogo { get; set; }

        public string Descrizione { get; set; }

        public string ImmagineDipartimento { get; set; }

        public Impiegato Leader { get; set; }
    }
}
