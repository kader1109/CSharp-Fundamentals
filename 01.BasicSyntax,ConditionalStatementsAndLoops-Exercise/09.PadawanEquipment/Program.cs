namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfTheLightsaber = double.Parse(Console.ReadLine());
            double priceOfTheRobe = double.Parse(Console.ReadLine());
            double priceOfTheBelt = double.Parse(Console.ReadLine());

            int freeBelts = countOfStudents / 6;

            double totalPrice = priceOfTheLightsaber * (countOfStudents + Math.Ceiling(countOfStudents * 0.1)) +
                                priceOfTheRobe * (countOfStudents) +
                                priceOfTheBelt * (countOfStudents - freeBelts);

            if (totalPrice <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(totalPrice-amountOfMoney):F2}lv more.");
            }
        }
    }
}
