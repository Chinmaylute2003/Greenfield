using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceEntities;

namespace Specification
{
    public interface IAuthService
    {
        bool Login(string email, string password);
        bool Register(User user);
        string ForgotPassword(string email);
        bool ResetPassword(string email, string oldPassword,  string newPassword);
    }
}
