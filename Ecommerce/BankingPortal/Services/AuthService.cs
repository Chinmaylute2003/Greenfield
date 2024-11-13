using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankingPortal.Repositories;
using BankingPortal.Models;
namespace BankingPortal.Services
{
	public class AuthService: IAuthService
	{
		
		private IDataRepository<User> svc = null;
		private IDataRepository<Credential> credSvc = null;
		private string userFilePath = @"E:/BankUser.json";
		private string credFilePath = @"E:/BankCredentials.json";
		public AuthService()
		{
			svc = new JSONRepository<User>();
			credSvc = new JSONRepository<Credential>();
			Seeding();
		}
		public bool Seeding()
		{
			User usr = new User
			{
				Id = 1,
				Email = "xyz@gmail.com",
				FirstName = "xyz",
				LastName = "pqr",
				Contact = "820213",
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
			List<Credential> creds = credSvc.Deserialize(credFilePath);
			
			foreach(Credential c in creds)
			{
				if(c.Email == email)
				{
					return c.Password;
				}
			}
			return null;
		}

		public bool Login(string email, string password)
		{
			List<Credential> creds = credSvc.Deserialize(credFilePath);
			foreach (Credential c in creds)
			{
				if (email == c.Email && password == c.Password)
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
			svc.Serialize(userFilePath, allUsers);
			List<Credential> creds = credSvc.Deserialize(credFilePath);
			creds.Add(new Credential { Email = user.Email, Password = user.Password});
			credSvc.Serialize(credFilePath, creds);

			return true;

		}

		public bool ResetPassword(string Email, string oldPassword, string newPassword)
		{
			List<Credential> creds = credSvc.Deserialize(credFilePath);
			foreach(Credential cred in creds)
			{
				if(cred.Email == Email && cred.Password == oldPassword)
				{
					cred.Password = newPassword;
					return true;
				}
			}
			return false;
		}
	}
}
