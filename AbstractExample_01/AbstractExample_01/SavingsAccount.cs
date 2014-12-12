using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample_01
{
    class SavingsAccount : Account
    {
        public double InterestRate { set; get; }

        public override string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdraw";
        }
    }
}
