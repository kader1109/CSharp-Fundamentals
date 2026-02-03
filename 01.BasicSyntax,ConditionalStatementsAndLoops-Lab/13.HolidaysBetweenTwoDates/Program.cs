using System.Globalization;

namespace _13.HolidaysBetweenTwoDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Globalization;

class HolidaysBetweenTwoDates
        {
            static void Main()
            {
                var startDate = DateTime.ParseExact(Console.ReadLine(),
                    "d.M.yyyy", CultureInfo.InvariantCulture);
                var endDate = DateTime.ParseExact(Console.ReadLine(),
                    "d.M.yyyy", CultureInfo.InvariantCulture);

                int holidays = 0;

                for (var date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday ||
                        date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        holidays++;
                    }
                }

                Console.WriteLine(holidays);
            }
        }

    }
}
}
