using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specification;
using BinaryDataRepositoryLib;
using EcommerceEntities;
using JSONDataRepositoryLib;


namespace EcommerceServices
{
    public class AuthService : IAuthService
    {
        private IDataRepository<User> svc = null;
        private IDataRepository<Credential> credSvc = null; 
        private string userFilePath = @"E:/user.json";
        private string credFilePath = @"E:/cred.json";
        public AuthService()
        {
            svc = new JSONRepository<User>();
            credSvc = new JSONRepository<Credential>();
          
        }
        public bool Seeding()
        {
            User usr = new User
            {
                Email = "xyz@gmail.com",
                FirstName = "xyz",
                LastName = "pqr",
                ContactNumber = "820213",
                Password = "123"
             

            };
            List<User> users = new List<User>();
            users.Add(usr);
            svc.Serialize(userFilePath, users);

            Credential dummyCred = new Credential
            {
                Email = "a@g.com",
                Password = "1234567"
            };
            List<Credential> creds = new List<Credential>();
            creds.Add(dummyCred);
            credSvc.Serialize(credFilePath, creds);
            return true;
           
        }
            
        public string ForgotPassword(string email)
        {
            List<User> users =  svc.Deserialize(userFilePath);
            foreach(User u in users)
            {
                if(u.Email == email)
                {
                    return u.Password;  
                }
            }
            return "User not found";
        }

        public bool Login(string email, string password)
        {
        
            List<Credential> creds = credSvc.Deserialize(credFilePath);
            foreach(Credential c in creds)
            {
                if(email == c.Email && password == c.Password)
                {
                    return true;
                }
                
                
            }
            return false;
        }

        public bool Register(User user)
        {
         
            List<User> allUsers = svc.Deserialize(userFilePath);
            allUsers.Add(user);
            List<Credential> creds = credSvc.Deserialize(credFilePath);
            creds.Add(new Credential { Email = user.Email, Password = user.Password });
            credSvc.Serialize(credFilePath, creds);
            svc.Serialize(userFilePath, allUsers);
            return true;

        }

        public bool ResetPassword(string Email, string oldPassword, string newPassword)
        {
            //List<User> users = svc.Deserialize(userFilePath);
            //foreach(User u in users){
            //    if(u.Email == Email && u.Password  == oldPassword)
            //    {
            //        u.Password = newPassword;
            //        svc.Serialize(userFilePath, users);
            //        return true;
            //    }
            //}
            return false;
        }
    }

}
