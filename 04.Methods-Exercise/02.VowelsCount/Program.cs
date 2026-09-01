namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower(); ;            

            VowelsCount(input);
        }
        static void VowelsCount(string input)
        {
            int vowelsCounter = 0;
            char[] chars = input.ToCharArray();
            

            foreach (char c in chars)
            {
                if (c == 'a' || c == 'o'
                                    || c == 'u'
                                    || c == 'e'
                                    || c == 'i')
                {
                    vowelsCounter++;
                }
            }
            Console.WriteLine(vowelsCounter);
        }
    }
}
