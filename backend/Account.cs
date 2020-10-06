using System;
using System.Collections.Generic;
namespace backend
{
    public class Account
    {
        public Boolean savings;
        public string accountType;
        public Int64 accountNr {get; set;}
        public decimal balance {get; set;}
        public List<Customer> customers;

        public void addCustomer()
        {
            Customer c = new Customer(0);
            customers.Add(c);
            if (c.birthDay < new date()-12 && savings) balance += 50;
        }

        public Customer indexer(int index)
        {
            return customers<index>;
        }

        static checkNumber(Int64 accountNr)
        {
            const numberLenght = 10;
            if (accountNr.length == numberLenght) Console.Write("This account number is valid"); 
            else Console.Write("This account number is not valid");
        }
    }
}   