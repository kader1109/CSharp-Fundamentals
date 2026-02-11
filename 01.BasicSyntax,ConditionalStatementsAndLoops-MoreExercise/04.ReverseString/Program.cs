namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reversedString = Console.ReadLine();

            for (int i = reversedString.Length-1; i >= 0; i--) {

                Console.Write(reversedString[i]);
            }
        }
    }
}
