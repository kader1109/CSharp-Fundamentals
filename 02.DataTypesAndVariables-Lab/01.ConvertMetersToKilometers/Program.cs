namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            double distanceInKilometers =(double)distanceInMeters /1000;

            Console.WriteLine($"{distanceInKilometers:f2}");
        }
    }
}
