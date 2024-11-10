using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegation;

namespace Banking
{
    public class Account
    {
        public event Operation underBalance, overBalance;
        //if you want to define, it is based on delegate    
        public double Balance { get; set; }
        public Account(double intialAmount)
        {
            Balance = intialAmount;
        }
        public void Widthdraw(double amount)
        {
            double result = Balance - amount;
            if (result <= 10000)
            {
                //raise an event
                underBalance(10);
            }
            Balance = result;

        }

        public void Deposit(double amount)
        {
            Balance += amount;
            if (Balance >= 20000)
            {
                //raise an event
                overBalance(5);
            }
        }
    }
}
