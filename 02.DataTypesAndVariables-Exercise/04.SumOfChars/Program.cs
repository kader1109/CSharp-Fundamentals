namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sum = 0;

            while (numberOfLines > 0)
            {
                char symbol = char.Parse(Console.ReadLine());
                int digit = symbol;
                sum += digit;
                numberOfLines--;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
