using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Work By Tom Harari - 301139588

namespace L10G_12_Lab10
{
    public class TransactionEventArgs : LoginEventArgs
    {
        public double Amount { get; }
        public TransactionEventArgs(string personName, double amount, bool success)
            : base(personName, success)
        {
            Amount = amount;
        }
    }
}
