using Employee.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Repository
{
   public class ImpiegatiRepository
    {
        private List<ImpiegatoModel> impiegati = new List<ImpiegatoModel>();
        public int AddImpiegato(ImpiegatoModel impiegato)
        {
            impiegato.Id = impiegati.Count+1; 
            impiegati.Add(impiegato);
            return impiegato.Id;
        }
        public List<ImpiegatoModel> GetAllImpiegati()
        {
            return impiegati;
        }
    }
}
