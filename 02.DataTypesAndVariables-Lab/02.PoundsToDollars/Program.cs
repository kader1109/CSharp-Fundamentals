namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal britishPound = decimal.Parse(Console.ReadLine());
            decimal dollars = britishPound * 1.31m;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
