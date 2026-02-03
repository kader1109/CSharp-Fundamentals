namespace _02.Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputGrade = double.Parse(Console.ReadLine());

            if (inputGrade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
