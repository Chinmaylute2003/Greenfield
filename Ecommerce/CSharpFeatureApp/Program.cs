using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;
using Taxation;
using Penalty;

namespace CSharpFeatureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Compile time, early binding, static linking

            /* Handler.PayGST();
            Handler.PayIncomeTax();
            Handler.PayProfessionalTax();
            Handler.PayServiceTax();*/

            //Register method with delegate instance

            //Dynamic invokation / Indirect calling of the handler functions.
            /*Operation opn1 = new Operation(Handler.PayIncomeTax);
            Operation opn2 = new Operation(Handler.PayServiceTax);
            Operation opn3 = new Operation(Handler.PayGST);*/

            //To invoke every operation you need to inoke them seperately
            //to call all operation invoke method in single stroke you can use master operation

            /*Operation masterOperation = null;
            masterOperation += opn1;
            masterOperation += opn3;
            masterOperation += opn2;*/

            //masterOperation.Invoke(50);

            Account acc = new Account(15000);
            acc.underBalance += PenaltyHandler.ServiceDisconnectPenaltyCharges;
            acc.underBalance += PenaltyHandler.NotificationPenaltyCharges;
            acc.overBalance += TaxHandler.PayServiceTax;

            acc.Widthdraw(8000);//
            acc.Deposit(6000);

            
            


          
            
            Console.ReadLine();
        }
    }
}
