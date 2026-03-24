namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().
                                Split().
                                Select(int.Parse).
                                ToArray();
            int[] arr2 = Console.ReadLine().
                                Split().
                                Select(int.Parse).
                                ToArray();

            int sum = 0;
            int indexToFind = 0;
            bool isEqual = true;

            for (int i = 0; i < arr1.Length; i++)
            {


                if (arr1[i] != arr2[i])
                {
                    isEqual = false;
                    indexToFind = i;
                    break;
                }

                sum += arr1[i];

            }
            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexToFind} index");
            }
        }
    }
}

