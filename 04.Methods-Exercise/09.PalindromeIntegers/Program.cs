namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END") {

                if (IsPalindrome(command))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
            
            }
        }
        static bool IsPalindrome(string command)
        {
            int left = 0;
            int right = command.Length - 1;

            while (left < right)
            {
                if (command[left] != command[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
