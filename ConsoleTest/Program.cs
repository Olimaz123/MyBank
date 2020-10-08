using System;
using backend;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean valid = false;
            // Console.WriteLine("What type of account do you want to create?");
            // Console.Write("Press 1 for current account, press 2 for savings account: ");
            // do {
            //     try{
            //         int choice = int.Parse(Console.ReadLine());
            //         if (choice == 1)
            //         {
            //             CurrentAccount cAcc = new CurrentAccount();
            //             Console.Write("You have selected: current account");
            //             valid = true;
            //             // cAcc.addCustomer(0);
            //         } 
            //         else if (choice == 2)
            //         {
            //             SavingsAccount sAcc = new SavingsAccount();
            //             Console.Write("You have selected: savings account");
            //             valid = true;
            //             // sAcc.addCustomer(0);
            //         } 
            //         else Console.Write("1 - That is not a valid choice, please try again: ");
            //     } catch {Console.Write("2 - That is not a valid choice, please try again: "); }
            // } while(valid == false);
            CurrentAccount cAcc = new CurrentAccount();
            cAcc.addCustomer(0);
        }
    }
}
