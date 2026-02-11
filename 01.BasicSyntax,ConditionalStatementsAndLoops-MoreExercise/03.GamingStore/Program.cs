using System;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balance = decimal.Parse(Console.ReadLine());
            decimal spent = 0;

            string command;

            while ((command = Console.ReadLine()) != "Game Time")
            {
                decimal price = 0;

                switch (command)
                {
                    case "OutFall 4": price = 39.99m; break;
                    case "CS: OG": price = 15.99m; break;
                    case "Zplinter Zell": price = 19.99m; break;
                    case "Honored 2": price = 59.99m; break;
                    case "RoverWatch": price = 29.99m; break;
                    case "RoverWatch Origins Edition": price = 39.99m; break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (price > balance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                balance -= price;
                spent += price;

                Console.WriteLine($"Bought {command}");

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance:f2}");
        }
    }
}
