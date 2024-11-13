using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceServices;
using EcommerceEntities;
namespace MembershipTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            AuthService auth = new AuthService();
            auth.Seeding();
            do
            {
                Console.WriteLine("Please select a choice");
                Console.WriteLine("1. Register New User");
                Console.WriteLine("2. Login New User");
                Console.WriteLine("3. Reset Password");
                Console.WriteLine("4. Forgot Password");
                Console.WriteLine("5. Exit");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        User newUser = new User();
                        Console.WriteLine("Email Firstname Lastname Contact Passsword");
                        newUser.Email = Console.ReadLine();
                        newUser.FirstName = Console.ReadLine();
                        newUser.LastName = Console.ReadLine();
                        newUser.ContactNumber = Console.ReadLine();
                        newUser.Password = Console.ReadLine();
                        auth.Register(newUser);
                        break;
                    case 2:
                        string email = Console.ReadLine();
                        string password = Console.ReadLine();
                        if(auth.Login(email, password))
                        {
                            Console.WriteLine("you are logged in");
                        }
                        else
                        {
                            Console.WriteLine("Please register");
                        }
                    break;
                    case 3:
                        Console.WriteLine("Email oldPassword newPassword");
;                       email = Console.ReadLine();
                        string oldPassword = Console.ReadLine();
                        string newPassword = Console.ReadLine();
                        if (auth.ResetPassword(email, oldPassword, newPassword))
                        {
                            Console.WriteLine("Password Changed Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("User not found");
                        }
                     break;
                    case 4:
                        Console.WriteLine("Email address");
                        email = Console.ReadLine();
                        Console.WriteLine(auth.ForgotPassword(email)); 
                        break;
                    case 5:
                        return;
                }
                    
               
            }while(true);
        }
    }
}
