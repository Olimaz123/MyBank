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
        public Account() 
        {
            // accountType = "";
            // Random r = new Random();
            // Console.WriteLine("What type of account do you want to create?");
            // Console.Write("Press 1 for current account, press 2 for savings account: ");
            // do {
            //     try{
            //         int choice = int.Parse(Console.ReadLine());
            //         if (choice == 1)
            //         {
            //             savings = false;
            //             accountType = "current account";
            //             String temp = "";
            //             for (int i = 0; i < 10; i++)
            //             {
            //                 temp += r.Next(0,9);
            //             }
            //             accountNr = Int64.Parse(temp);
            //         } 
            //         else if (choice == 2)
            //         {
            //             savings = true;
            //             accountType = "savings account";
            //             accountNr = (1230000000 + r.Next(1000000,9999999));
            //         } 
            //         else Console.Write("That is not a valid choice, please try again: ");
            //     } catch {Console.Write("That is not a valid choice, please try again: "); }
            // } while(accountType.Equals(""));
            // Console.WriteLine(accountType);
            // Console.WriteLine(accountNr);
        }
    }

}   