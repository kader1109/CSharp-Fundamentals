namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;
            int sumFactoriel = 0;

            while (number > 0)
            {
                int digit = number % 10;
                int factoriel = 1;

                for (int i = 1; i <= digit; i++)
                {
                    factoriel *= i;
                }
                sumFactoriel += factoriel;
                number = number / 10;
            }
            if(sumFactoriel == originalNumber)
            {
                Console.WriteLine("yes");

            }
            else Console.WriteLine("no");
        }
    }
}
