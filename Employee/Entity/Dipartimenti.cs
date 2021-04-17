using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Entity
{
    public class Dipartimenti
    {
        [Key]
        public int GeoCode { get; set; }

        public string Nome { get; set; }

        public string Luogo { get; set; }

        public string Descrizione { get; set; }

        public string ImmagineDipartimento { get; set; }

        public Impiegato Leader {get;set;}

    }
}
