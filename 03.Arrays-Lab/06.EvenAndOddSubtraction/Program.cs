namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().
                                Split().
                                Select(int.Parse).
                                ToArray();

            int sumEvenNumbers = 0;
            int sumOddNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumbers = numbers[i];

                if (currentNumbers % 2 == 0)
                {
                    sumEvenNumbers += currentNumbers;
                }
                else
                {
                    sumOddNumbers += currentNumbers;
                }
            }

            Console.WriteLine(sumEvenNumbers - sumOddNumbers);


        }


    }

}

