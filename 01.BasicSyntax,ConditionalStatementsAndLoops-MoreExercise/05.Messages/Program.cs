namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int length = input.Length;
                int digit = input[0] - '0';

                if (digit == 0)
                {
                    message += " ";
                    continue;
                }

                int offset = (digit - 2) * 3;

                if (digit == 8 || digit == 9)
                {
                    offset++; // because 7 and 9 have 4 letters
                }

                int letterIndex = offset + (length - 1);
                char letter = (char)('a' + letterIndex);

                message += letter;
            }

            Console.WriteLine(message);

        }
    }
}
