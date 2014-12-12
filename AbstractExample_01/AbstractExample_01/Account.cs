using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample_01
{
    abstract class Account
    {
        public string No { set; get; }
        public double Balance { protected set; get; }
        public string Deposit(double amount)
        {
            Balance += amount;
            return "Done";
        }

        public abstract string Withdraw(double amount);

    }
}
