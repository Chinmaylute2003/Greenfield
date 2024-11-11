using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            //Singleton class: it restrict user to only create single object of class
            OfficeBoy p1 = OfficeBoy.Create();
            OfficeBoy p2 = OfficeBoy.Create();
        }
    }
}
