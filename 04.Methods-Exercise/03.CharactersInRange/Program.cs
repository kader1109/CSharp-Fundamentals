namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            CharactersInRange(start, end);
        }

        private static void CharactersInRange(char start, char end) {
            if (end < start)
            {
                char temp = start;
                start = end;
                end = temp;
            }

            // Обхождаме всички символи между тях
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }


        }
    }
}
