namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeAfterMinutes = 30;

            int allTheTime = (hour * 60) + minutes + timeAfterMinutes;

            int realHour = allTheTime / 60;
            int realMinute = allTheTime % 60;

            if (realHour > 23)
            {
                realHour = 0;
            }
            if (realMinute > 59)
            {
                realMinute = 0;
                realHour += 1;
            }

            Console.WriteLine($"{realHour}:{realMinute:D2}");

        }
    }
}
