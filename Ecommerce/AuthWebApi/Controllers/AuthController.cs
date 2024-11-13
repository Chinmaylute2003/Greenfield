using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EcommerceEntities;
using EcommerceServices;


namespace AuthWebApi.Controllers
{
    public class AuthController : ApiController
    {
        private AuthService svc;
        public AuthController()
        {
            svc = new AuthService();
        }
        public void Post([FromBody] User value)
        {
            svc.Register(value);
        }

        public bool Post([FromBody] Credential cred)
        {
            return svc.Login(cred.Email, cred.Password);
        }

    }
}
