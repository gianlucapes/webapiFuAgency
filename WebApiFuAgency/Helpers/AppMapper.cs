using AutoMapper;
using Employee.Entity;
using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFuAgency.Helpers
{
    public class AppMapper : Profile 
    {
        public AppMapper()
        {
            CreateMap<Impiegato, ImpiegatoModel>().ReverseMap();
            CreateMap<Dipartimenti, Dipartimenti>().ReverseMap();
        }

    }
}
