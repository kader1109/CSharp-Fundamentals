namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input
                = Console.ReadLine();

            while (input != "END")
            {
                if (int.TryParse(input, out int intValue))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out double doubleValue))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (bool.TryParse(input, out bool boolValue))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (input.Length == 1)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
