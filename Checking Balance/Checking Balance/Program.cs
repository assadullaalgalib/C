﻿using System;

namespace exercise_106
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            balance = openingBalance;
        }

        public override string ToString()
        {
            return "The card has a balance of " + balance + " euros";
        }

        public void EatLunch()
        {
            // Check if there's enough balance for lunch
            if (balance >= 10.60)
            {
                balance -= 10.60;
            }
        }

        public void DrinkCoffee()
        {
            // Decrease the card's balance by 2.0 euros for coffee
            balance -= 2.0;
        }

        public static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(10);
            Console.WriteLine(card);

            card.EatLunch();
            Console.WriteLine(card);

            card.DrinkCoffee();
            Console.WriteLine(card);
        }
    }
}
