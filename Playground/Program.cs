namespace Playground
{
    internal class Program
    {

        class Data
        {
            public int Number;
        }

        static void Main()
        {
            Data d1 = new Data();
            d1.Number = 1;

            Data d2 = new Data();
            d2.Number = 2;

            Swap(d1, d2);

            Console.WriteLine(d1.Number);
            Console.WriteLine(d2.Number);
        }

        static void Swap(Data a, Data b)
        {
            Data temp = a;
            a = b;
            b = temp;
        }
    }
}

