namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballsN = int.Parse(Console.ReadLine());

            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;
            double bestValue = 0;

            for (int i = 0; i < snowballsN; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                double snowballValue = Math.Pow((double)snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > bestValue)
                {
                    bestValue = snowballValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
