using EcommerceEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Specification;
using JSONDataRepositoryLib;
using System.IO;
using Newtonsoft.Json;
using EcommerceServices;
namespace AuthWebApi.Controllers
{
    public class UsersController : ApiController
    {

        // GET: Users
        public IAuthService svc;
        public IDataRepository<User> repo;
        private string filePath = @"E:/user.json";
        public UsersController()
        {
            svc = new AuthService();
            repo = new JSONRepository<User>();
            
        }
            
        public IEnumerable<User> Get()
        {
            string jsonData = File.ReadAllText(filePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);
            return users;
        }

        public User Get(int id)
        {
            User user = new User();
            string jsonData = File.ReadAllText(filePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);
            foreach(User u in users)
            {
                if(u.Id == id)
                {
                    user = u;
                }
            }
            return user;

        }

        public void Post([FromBody] User value)
        {
            svc.Register(value);
        }

       




    }
}