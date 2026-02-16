namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double lentght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double V = (lentght * width * h) / 3;

            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            Console.Write($"Pyramid Volume: {V:f2}");

        }
    }
}
