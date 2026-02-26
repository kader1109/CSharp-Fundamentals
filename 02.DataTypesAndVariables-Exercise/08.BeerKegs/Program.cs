using System.Reflection;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string modelOfTheKeg = null;

            string biggestModel = "";
            double biggestVolume = 0;

            for (int i = 0; i < n; i++)
            {
                modelOfTheKeg = Console.ReadLine();
                double radiusOfTheKeg = double.Parse(Console.ReadLine());
                int heightOfTheKeg = int.Parse(Console.ReadLine());

                double volumeOfTheKeg = Math.PI * heightOfTheKeg * (Math.Pow(radiusOfTheKeg, 2));

                if (volumeOfTheKeg > biggestVolume)
                {
                    biggestVolume = volumeOfTheKeg;
                    biggestModel = modelOfTheKeg;
                }

            }
            Console.WriteLine(biggestModel);
        }
    }
}
