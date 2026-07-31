namespace Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSequence = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "Clone them!")
            {
                for (int i = 0; i < lengthOfSequence; i++)
                {
                    int[] sequences = Console.ReadLine()
                                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
                    for (int j = 0; j < sequences.Length; j++)
                    {
                        for (int k = j + 1; k < sequences.Length; k++)
                        {
                            if (sequences[k] == sequences[j])
                            {
                                Console.WriteLine($"Best DNA sample {k} with sum: {sequences[k] + sequences[j]} .");
                            }
                            else
                            {
                                Console.WriteLine("{DNA sequence, joined by space}");
                            }
                        }
                    }

                }
            }
        }
    }
}
