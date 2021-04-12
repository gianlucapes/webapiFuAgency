using Employee.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Data
{
   public class ImpiegatiContext : DbContext
   {
        public ImpiegatiContext(DbContextOptions<ImpiegatiContext> option)
            : base(option)
        {

        }
        public DbSet<Impiegato> Impiegato { get; set; }

      
   }
}
