using Employee.Repository;
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
        private readonly IAccountRepository acountRepository;

        public AccountController(IAccountRepository _acountRepository)
        {
            this.acountRepository = _acountRepository;
        }
    }
}
