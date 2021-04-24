using Employee.Models;
using Employee.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFuAgency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository accountRepository;

        public AccountController(IAccountRepository _accountRepository)
        {
            this.accountRepository = _accountRepository;
        }

        [HttpPost("signUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUpModel signUpModel)
        {
            var result = await accountRepository.SingUp(signUpModel);

            if(result.Succeeded)
            {
                return Ok();
            }
            return Unauthorized(result.Errors);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] SigninModel signinModel)
        {
            var result = await accountRepository.LoginAsync(signinModel);

            if (String.IsNullOrEmpty(result))
            {
              return  Unauthorized("Email o password errati");
            }
            return Ok(result);
        }
    }
}
