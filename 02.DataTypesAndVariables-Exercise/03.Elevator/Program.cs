namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// count of people
            int p = int.Parse(Console.ReadLine()); // capacity

            int courses = (int)Math.Ceiling((double)n / p);
            Console.WriteLine(courses);
            
        }
    }
}
