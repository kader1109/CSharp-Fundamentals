using System;

namespace _07.MaxSequenceОfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            int bestCount = 1;
            int currentCount = 1;
            int bestNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestNumber = numbers[i];
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(bestNumber + " ");
            }



        }
    }
}
