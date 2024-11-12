using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AuthWebApi.Controllers
{
    public class UsersController : ApiController
    {
        // GET: Users
        public 
        public IEnumerable<Product> Get()
        {
            List<Product> products = svc.GetAll();
            return products;
        }
    }
}