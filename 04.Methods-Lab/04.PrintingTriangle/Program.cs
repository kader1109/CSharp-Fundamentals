namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = int.Parse(Console.ReadLine());

            Print(start, end);

        }
        static void Print (int start, int end)
        {
            for (int i = 0; i <= end; i++)
            {
                for (int j = start; j <= i; j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();

            }
            for (int i = end - 1; i >= start; i--)
            {
                for (int j = start; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
