using System;
using System.Collections.Generic;

namespace backend
{
    public class Customer
    {
        public int id;
        public string name;
        public int phoneNumber;
        public DateTime birthDay;
        // public List<Card> cards;

        public Customer(int currentUsers, string name, DateTime birthDay, int phoneNumber) 
        {
            id = currentUsers+1;
            name = this.name;
            birthDay = this.birthDay;
            phoneNumber = this.phoneNumber;
        }

        public Customer(int currentUsers) 
        {
            id = currentUsers+1;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your birthday in the form dd/mm/yyyy: ");
            do 
            {
                try
                {
                    birthDay = DateTime.Parse(Console.ReadLine());
                } catch {
                    Console.Write("This is not a valid date. Please try again: ");
                }
            } while(birthDay == default(DateTime));

            Console.Write("Please enter your phonenumber: ");
            do
            {
                try    
                {
                    phoneNumber = int.Parse(Console.ReadLine());
                } catch {
                    Console.Write("This is not a valid phone number. Please try again: ");
                }
            } while(phoneNumber == 0);
        }
    }
}
