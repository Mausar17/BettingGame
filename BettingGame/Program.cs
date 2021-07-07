using System;
using Guys;

namespace BettingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() {cashOnGuy = 100, name = "The player"};

            Console.WriteLine("Welcome to the casino. The odds are " + odds);

            while (player.cashOnGuy > 0)
            {
                player.WriteMyInfo();
                Console.Write("How much do you want to bet? \t");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = amount * 2;
                    double playerOdds = random.NextDouble();

                    if (playerOdds > odds)
                    {
                        Console.WriteLine("You win $" + pot + ".");
                        player.ReceiveCash(pot);
                    }
                    else
                    {
                        Console.WriteLine("Bad luck, you lose.");
                        player.GiveCash(amount);
                    }
                }

                Console.WriteLine("Please enter a valid number.");
            }

            Console.WriteLine("Gameover, the house always wins.");
        }
    }
}
