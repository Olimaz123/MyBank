using System;
using System.Collections.Generic;
namespace backend
{
    public class SavingsAccount: Account
    {
        public SavingsAccount()
        {
            Random r = new Random();
            savings = true;
            accountType = "savings account";
            accountNr = (1230000000 + r.Next(1000000,9999999));
        }

    }
}