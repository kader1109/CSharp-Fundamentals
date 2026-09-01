namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int num = 0; num < number; num++)
            {
                if (IsDividedByEight(num) && IsTheNumberHasOddNumberInYourself(num))
                {
                    Console.WriteLine(num);

                }

            }
        }

        private static bool IsDividedByEight(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum % 8 == 0;
        }
        private static bool IsTheNumberHasOddNumberInYourself(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
}
