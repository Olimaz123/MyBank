using System;
using System.Collections.Generic;
namespace backend
{
    public class account
    {
        public Boolean savings;
        public string accountType;
        public Int32 accountNr;
        public decimal balance;
        public List<Customer> customers;
        public List<Card> cards;

        public account() 
        {
            if(savings == true) accountType = "Savings account";
            else accountType = "Current account";
        }
    }
}   