﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10G_12_Lab10
{
    public interface ITransaction
    {
        void Withdraw(double amount, Person person);
        void Deposit(double amount, Person person)
    }
}
