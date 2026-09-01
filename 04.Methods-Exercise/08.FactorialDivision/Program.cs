namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            long resultOfFirstNumber = GetFactoriel(num1);
            long resultOfSecondNumber = GetFactoriel(num2);

            if (DivideByZeroException(num2))
            {
                double divideResult =(double)resultOfFirstNumber / resultOfSecondNumber;
                Console.WriteLine($"{divideResult:f2}");
            }
            else
            {
                Console.WriteLine();
            }



        }

        private static long GetFactoriel(int num)
        {

            long result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        private static bool DivideByZeroException(int num2)
        {
            if (num2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


    }
}
