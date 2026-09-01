namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Characters(input);
        }

        private static void Characters(string input)
        {
            if (input.Length % 2 != 0)
            {
                int midleIndex = input.Length / 2;
                Console.WriteLine($"{input[midleIndex]}");
            }
            else
            {
                int leftPart = (input.Length / 2) - 1;
                int rightPart = input.Length / 2;
                Console.WriteLine($"{input[leftPart]}{input[rightPart]}");
            }
        }
    }
}
