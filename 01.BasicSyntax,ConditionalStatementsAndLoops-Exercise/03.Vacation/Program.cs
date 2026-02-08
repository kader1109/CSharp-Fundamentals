namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string theDayOfTheWeek = Console.ReadLine();

            double singleTicketPrice = 0;
            double totalPrice = 0;

            switch (typeOfTheGroup)
            {
                case "Students":
                    switch (theDayOfTheWeek)
                    {
                        case "Friday":
                            singleTicketPrice = 8.45;
                            totalPrice = countOfPeople * singleTicketPrice;
                            break;
                        case "Saturday":
                            singleTicketPrice = 9.80;
                            totalPrice = countOfPeople * singleTicketPrice;
                            break;
                        case "Sunday":
                            singleTicketPrice = 10.46;
                            totalPrice = countOfPeople * singleTicketPrice;
                            break;
                    }
                    if (countOfPeople >= 30)
                    {                        
                        totalPrice = countOfPeople * singleTicketPrice;
                        totalPrice *= 0.85;
                    }
                    break;

                case "Business":
                    switch (theDayOfTheWeek)

                    {
                        case "Friday":
                            singleTicketPrice = 10.90;
                            totalPrice = countOfPeople * singleTicketPrice;
                            break;
                        case "Saturday":
                            singleTicketPrice = 15.60;
                            totalPrice = countOfPeople * singleTicketPrice;
                            break;
                        case "Sunday":
                            singleTicketPrice = 16;
                            totalPrice = countOfPeople * singleTicketPrice;
                            break;
                          
                    }
                    if (countOfPeople > 100)
                    {
                        countOfPeople -= 10;
                        totalPrice = countOfPeople* singleTicketPrice;
                    }
                    break;

                case "Regular":
                    switch (theDayOfTheWeek)
                    {
                        case "Friday":
                            singleTicketPrice = 15;
                            totalPrice = countOfPeople * singleTicketPrice;
                            break;
                        case "Saturday":
                            singleTicketPrice = 20;
                            totalPrice = countOfPeople * singleTicketPrice;
                            break;
                        case "Sunday":
                            singleTicketPrice = 22.50;
                            totalPrice = countOfPeople * singleTicketPrice;
                            break;                            
                    }

                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;

            }
            Console.WriteLine($"Total price: {totalPrice:F2}");

        }
    }
}
/*
 
40
Regular
Sunday

 */