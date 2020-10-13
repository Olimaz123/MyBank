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
        public List<Customer> customers = new List<Customer>();

        public void addCustomer()
        {
            Customer c = new Customer(customers.Count);
            customers.Add(c);
            Console.WriteLine("Customer added");
            DateTime today = new DateTime();
            today = DateTime.Today;
            if (today.Subtract(c.birthDay).TotalDays < 4380 && savings == false)
            {
                balance += 50;
            } 
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