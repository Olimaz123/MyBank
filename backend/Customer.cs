using System;
using System.Collections.Generic;

namespace backend
{
    public class Customer
    {
        public int id;
        public string name;
        public Int64 phoneNumber;
        public date birthDay;
        public List<Card> cards;

        public Customer(int currentUsers, string name, date birthDay, Int64 phoneNumber) 
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
                    birthDay = date.Parse(Console.ReadLine());
                } catch {
                    Console.Write("This is not a valid date. Please try again: ");
                }
            } while(birthDay = null);

            Console.Write("Please enter your phonenumber: ");
            do
            {
                try    
                {
                    phoneNumber = Int64.Parse(Console.ReadLine());
                } catch {
                    Console.Write("This is not a valid phone number. Please try again: ");
                }
            } while(phoneNumber == 0);
        }
    }
}
