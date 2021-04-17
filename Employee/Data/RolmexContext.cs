using Employee.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Data
{
   public class RolmexContext : DbContext
   {
        public RolmexContext(DbContextOptions<RolmexContext> option)
            : base(option)
        {

        }
        public DbSet<Impiegato> Impiegato { get; set; }

        public DbSet<Dipartimenti> Dipartimenti { get; set; }
      
   }
}
