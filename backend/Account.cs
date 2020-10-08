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

        public void addCustomer(int customerCount)
        {
            Customer c = new Customer(customerCount);
            customers.Add(c);
            Console.WriteLine("Customer added");
            DateTime today = new DateTime();
            today = DateTime.Today;
            if (today.Subtract(c.birthDay).TotalDays < 4380) balance += 50;
        }

        public Customer indexer(int index)
        {
            return customers[index];
        }

        static void checkNumber(Int64 accountNr)
        {
            const int numberLenght = 10;
            if (accountNr.ToString().Length == numberLenght) Console.Write("This account number is valid"); 
            else Console.Write("This account number is not valid");
        }

        public int getCustomerCount()
        {
            return customers.Count;
        }
    }
}   