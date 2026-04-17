namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool IsTop = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] >= numbers[i])
                    {
                        IsTop = false;
                        break;
                    }
                }

                if (IsTop)
                {
                    Console.Write(numbers[i] + " ");
                }

            }
        }
    }
}
