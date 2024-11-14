﻿using BankingPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingPortal.Services
{
    public interface IAuthService
    {
        bool Login(string email, string password);
        bool Register(User user);
        string ForgotPassword(string email);
        bool ResetPassword(string email, string oldPassword, string newPassword);
    }
}