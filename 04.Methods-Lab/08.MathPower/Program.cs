namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = RiseToPower(baseNumber, power);
            Console.WriteLine(result);
        }
        private static double RiseToPower(double baseNumber, double power)
        {
            double result = 0d;

            for (int i = 0; i <= power; i++)
            {
                result = Math.Pow(baseNumber, i);
            }

            return result;
        }
    }
}
