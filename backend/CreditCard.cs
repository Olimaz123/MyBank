using System;

namespace backend
{
    public class CreditCard : Card
    {
        public int cvc {get; set;}
        public decimal balance {get; set;}

        public CreditCard()
        {
            cvc = cardNumber%987;
        }
        public void WithdrawMoney(decimal money)
        {
            balance -= money;
        }
        
    }
}