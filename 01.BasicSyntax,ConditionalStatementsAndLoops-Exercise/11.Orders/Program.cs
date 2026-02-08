namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countsOfTheOrders = int.Parse(Console.ReadLine());

            double totalSum = 0;

            for (int i = 0; i < countsOfTheOrders; i++)
            {
                double priceOfTheCapsule = double.Parse(Console.ReadLine());
                int dayInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double orderPrice = (dayInMonth * capsulesCount) * priceOfTheCapsule;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");

                totalSum += orderPrice;
            }

            Console.WriteLine($"Total: ${totalSum:F2}");

        }
    }
}

