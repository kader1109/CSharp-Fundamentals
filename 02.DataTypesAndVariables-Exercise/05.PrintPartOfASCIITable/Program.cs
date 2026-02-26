namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int lastIndex = int.Parse(Console.ReadLine());

            char symbol = '0';

            for (int i = startIndex; i <= lastIndex; i++)
            {
                symbol = (char)i;

                Console.Write(symbol + " ");
            }
        }
    }
}
