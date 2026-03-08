namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string message= string.Empty;


            for (int i = 0; i < n; i++)
            {
                string inputChar = Console.ReadLine();

                char ch= inputChar[0];
                char decryptedChar= (char)(ch + key);

                message += decryptedChar;               

            }
            Console.WriteLine(message);
        }
    }
}
