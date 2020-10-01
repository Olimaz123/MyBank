using System;

namespace backend
{
    public class Customer
    {
        public int id;
        public string name;
        public Int32 phoneNumber;
        public string birthDay;

        public Customer(int id, string name, string birthDay, Int32 phoneNumber) 
        {
            id = this.id;
            name = this.name;
            birthDay = this.birthDay;
            phoneNumber = this.phoneNumber;
        }

        public Customer(int id) 
        {
            id = this.id;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your birthday: ");
            birthDay = Console.ReadLine();
            Console.WriteLine("Please enter your phonenumber: ");
            do
            {
                try    
                {
                    phoneNumber = Int32.Parse(Console.ReadLine());
                } catch {
                    Console.WriteLine("This is not a valid phone number. Please try again.");
                }
            } while(phoneNumber == 0);
        }
    }
}
