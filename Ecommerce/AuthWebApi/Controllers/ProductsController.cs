using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services;
using POCO;

namespace AuthWebApi.Controllers
{
    public class ProductsController : ApiController
    {
        private ProductService svc;
        // GET api/values

        public ProductsController()
        {
            svc = new ProductService();
        }
        
        public IEnumerable<Product> Get()
        {
            List<Product> products = svc.GetAll();
            return products;
        }

        // GET api/values/5
        public Product Get(int id)
        {
            return svc.GetProduct(id);
        }

        // POST api/values
        public void Post([FromBody] Product value)
        {
            svc.Insert(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Product value)
        {
            svc.Update(value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            svc.Delete(svc.GetProduct(id));
        }
    }
}
