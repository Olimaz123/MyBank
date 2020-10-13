using System;
using System.Collections.Generic;
namespace backend
{
    public class CurrentAccount: Account
    {
        public List<Card> cards = new List<Card>();

        public CurrentAccount()
        {
            Random r = new Random();
            savings = false;
            accountType = "current account";
            String temp = "";
            for (int i = 0; i < 10; i++)
            {
                temp += r.Next(0,9);
            }
            accountNr = Int64.Parse(temp);
            Console.WriteLine(accountNr);
        }

        public void WithdrawMoney(decimal money)
        {
            balance -= money;
        }

        public void DepositMoney(decimal money)
        {
            balance += money;
        }

        public void addCard(Card c)
        {
            cards.Add(c);
        }

        public void removeCard(index i)
        {
            cards.Remove(i);
        }
    }
}