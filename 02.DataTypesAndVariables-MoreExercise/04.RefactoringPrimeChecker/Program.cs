namespace _04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            for (int num = 2; num <= numbers; num++) 
            { 
                bool IsRange = true; 

                for (int divider = 2; divider < num; divider++)
                {
                    if (num % divider == 0)
                    {
                        IsRange = false;
                        break; 
                    } 
                } 
                Console.WriteLine($"{num} -> {IsRange.ToString().ToLower()}"); 
            }

        }
    }
}
