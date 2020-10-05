using System;

namespace backend
{
    public class Customer
    {
        public int id;
        public string name;
        public Int64 phoneNumber;
        public string birthDay;

        public Customer(int currentUsers, string name, string birthDay, Int64 phoneNumber) 
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
            Console.Write("Please enter your birthday: ");
            birthDay = Console.ReadLine();
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
