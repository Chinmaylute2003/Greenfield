using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specification;
using BinaryDataRepositoryLib;
using POCO;

namespace Membership
{
    public class AuthService : IAuthService
    {
        private IDataRepository<User> svc = null;
        private string fileName = "User.dat";
        public AuthService()
        {
            svc = new BinaryRepository<User>();
        }
        public bool Seeding()
        {
            User usr = new User
            {
                Email = "xyz@gmail.com",
                FirstName = "xyz",
                LastName = "pqr",
                ContactNumber = "820213",
                Password = "1234"

            };
            List<User> users = new List<User>();
            users.Add(usr);
            svc.Serialize(fileName, users);
            return true;
        }
            
        public string ForgotPassword(string email)
        {
            List<User> users =  svc.Deserialize(fileName);
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
            List<User> users = svc.Deserialize(fileName);
            foreach(User u in users)
            {
                if(email == u.Email)
                {
                    return true;
                }
                
                
            }
            return false;
        }

        public bool Register(User user)
        {
            List<User> allUsers = svc.Deserialize(fileName);
            allUsers.Add(user);
            svc.Serialize(fileName, allUsers);
            return true;

        }

        public bool ResetPassword(string Email, string oldPassword, string newPassword)
        {
            List<User> users = svc.Deserialize(fileName);
            foreach(User u in users){
                if(u.Email == Email && u.Password  == oldPassword)
                {
                    u.Password = newPassword;
                    svc.Serialize(fileName, users);
                    return true;
                }
            }
            return false;
        }
    }

}
