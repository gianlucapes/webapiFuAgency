using Employee.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Repository
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SingUp(SignUpModel signUpModel);

        public Task<String> LoginAsync(SigninModel signinModel);
    }
}
