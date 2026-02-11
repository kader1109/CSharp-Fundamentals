namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                int max = a;

                if (b > max)
                    max = b;

                if (c > max)
                    max = c;

                Console.WriteLine(max);
                                
                if (max == a)
                    a = int.MinValue;
                else if (max == b)
                    b = int.MinValue;
                else
                    c = int.MinValue;
            }

        }


    }
}

