namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int specialNumber = 0;
            bool IsSpesialNumber = false;
            for (int num = 1; num <= number; num++)
            {
                specialNumber = num;
                while (num > 0)
                { sum += num % 10; num = num / 10;
                }
                IsSpesialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", specialNumber, IsSpesialNumber); 
                sum = 0;
                num = specialNumber;
            }
        }
    }
}
