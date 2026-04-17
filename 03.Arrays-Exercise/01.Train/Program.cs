namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] trainPasagers = new int[n];
            int total = 0;
            for (int i = 0; i < n; i++)
            {

                trainPasagers[i] = int.Parse(Console.ReadLine());
                total += trainPasagers[i];
            }
            foreach (int trainPasager in trainPasagers)
            {
                Console.Write(trainPasager + " ");

            }
            Console.WriteLine();
            Console.WriteLine(total);
        }
    }
}
