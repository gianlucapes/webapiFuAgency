﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Models
{
   public class ApplicationUser : IdentityUser 
    {
        public string FirstName { get; set; }

        public string FamilyName { get; set; }
    }
}