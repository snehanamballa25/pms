using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pms.Interface;
using pms.Models;

namespace pms.Controllers
{   //will be pssing the path api/Login/login
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        protected readonly Ilogin _ilogin;
        public LoginController(Ilogin ilogin) {
            _ilogin = ilogin;
                }
       [Route("login")] //creating route for login
        public string ValidateCred([FromBody]Personal personal) 
        {
            string designation = _ilogin.signin(personal);
            return designation;
        }

    }
}
