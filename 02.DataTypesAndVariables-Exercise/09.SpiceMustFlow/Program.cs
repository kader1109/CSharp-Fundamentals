namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalSpice = 0;

            while (startingYield >= 100)
            {
                totalSpice += startingYield;
                startingYield -= 10;
                totalSpice -= 26;
                days++;
            }
            if (totalSpice >= 26)
            {
                totalSpice -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(totalSpice);
        }
    }
}
