namespace _05.AddАndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = AddNumbers(num1, num2);
            int result = SubtractNumbers(sum, num3);
                        
            Console.WriteLine(result);

        }

        private static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        private static int SubtractNumbers( int sum,int num3)
        {
            return sum - num3;
        }
    }

}
