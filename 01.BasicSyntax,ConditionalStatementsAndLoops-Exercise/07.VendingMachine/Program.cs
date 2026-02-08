using System;
using System.Linq;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sumOfCoins = 0;

            double[] validCoins = { 2, 1, 0.5, 0.2, 0.1 };

            
            while (command != "Start")
            {
                double coins = double.Parse(command);

                if (!validCoins.Contains(coins))
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else
                {
                    sumOfCoins += coins;
                }

                command = Console.ReadLine();
            }

           
            command = Console.ReadLine();

            while (command != "End")
            {
                double price = 0;

                if (command == "Nuts") price = 2.0;
                else if (command == "Water") price = 0.7;
                else if (command == "Crisps") price = 1.5;
                else if (command == "Soda") price = 0.8;
                else if (command == "Coke") price = 1.0;
                else
                {
                    Console.WriteLine("Invalid product");
                    command = Console.ReadLine();
                    continue;
                }

                if (sumOfCoins >= price)
                {
                    sumOfCoins -= price;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                command = Console.ReadLine();
            }

            
            Console.WriteLine($"Change: {sumOfCoins:F2}");
        }
    }
}
