namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol= char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            string combinatedSymbols =$"{firstSymbol}{secondSymbol}{thirdSymbol}";

            Console.WriteLine(combinatedSymbols);
        }
    }
}
