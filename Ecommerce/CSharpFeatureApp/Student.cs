using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureApp
{
    public  class Person
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            FirstName = "Brock";
            LastName = "Lesnar";
        }
        public readonly int PlankConstant;
        public const double PI = 3.14;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            PlankConstant = 1;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        public void showDetails()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }

    public class Employee : Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee()
        {
            Id = 1;
            Name = "Employee1";
        }
        public static void displayDetails(object o)
        {
            Console.WriteLine(o);
        }
    }

    }
