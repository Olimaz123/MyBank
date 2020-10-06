using System;
using backend;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer c = new Customer(0);
            // Account acc = new Account();
            Boolean valid = false;
            Console.WriteLine("What type of account do you want to create?");
            Console.Write("Press 1 for current account, press 2 for savings account: ");
            do {
                try{
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        CurrentAccount cAcc = new CurrentAccount();
                        valid = true;
                        // cAcc.addCustomer();
                    } 
                    else if (choice == 2)
                    {
                        SavingsAccount sAcc = new SavingsAccount();
                        valid = true;
                    } 
                    else Console.Write("That is not a valid choice, please try again: ");
                } catch {Console.Write("That is not a valid choice, please try again: "); }
            } while(valid == false);
        }
    }
}
