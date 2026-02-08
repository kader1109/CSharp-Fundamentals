using System;

class Program
{
    static void Main()
    {
        string username = Console.ReadLine();
        string password = new string(username.Reverse().ToArray());

        int attempts = 0;

        while (true)
        {
            string attempt = Console.ReadLine();
            attempts++;

            if (attempt == password)
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }

            if (attempts == 4)
            {
                Console.WriteLine($"User {username} blocked!");
                break;
            }

            Console.WriteLine("Incorrect password. Try again.");
        }
    }
}
