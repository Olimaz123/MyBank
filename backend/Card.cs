using System;

namespace backend
{
    public class Card
    {
        public int cardNumber {get; set;}
        public int pinNumber {get; set;}
        // public Customer owner {get; set;}

        public Card()
        {
            Random r = new Random();
            cardNumber = r.Next(10000000, 99999999);
            // this.owner = owner;
        }
        
    }
}