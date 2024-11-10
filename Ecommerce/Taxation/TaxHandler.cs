using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxation
{
    public class TaxHandler
    {
        public static void PayIncomeTax(float factor)
        {
            Console.WriteLine("Income tax has been deducted from your account = " + factor);
        }
        public static void PayServiceTax(float factor)
        {
            Console.WriteLine("Service tax has been deducted from your account = " + factor);
        }
        public static void PayProfessionalTax(float factor)
        {
            Console.WriteLine("Professional tax has been deducted from your account = " + factor);
        }
        public static void PayGST(float factor)
        {
            Console.WriteLine("GST tax has been deducted from your account = " + factor);
        }

    }
}
