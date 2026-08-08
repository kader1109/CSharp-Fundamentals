namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Price per stock
            double coffee = 1.50;
            double water = 1.00;
            double coke = 1.40;
            double snacks = 2.0;
            // inputs

            string product = Console.ReadLine();
            int countOfProducts= int.Parse(Console.ReadLine());

            Console.WriteLine($"{Calculate(product, countOfProducts):F2}");

        }
        static double Calculate(string product, int countOfProducts)
        {
            double coffee = 1.50;
            double water = 1.00;
            double coke = 1.40;
            double snacks = 2.0;

            double total = 0;

            switch (product)
            {
                case "coffee":
                    total= (double)countOfProducts * coffee;
                    break;
                case "water":
                    total = countOfProducts * water;
                    break;
                case "coke":
                    total = countOfProducts * coke;
                    break;
                case "snacks":
                    total = countOfProducts * snacks;
                    break;
            }
            return (double)total;
        }
    }
}
