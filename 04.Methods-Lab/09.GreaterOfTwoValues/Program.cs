namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            bool IsInputInt1 = int.TryParse(input1, out int number1);
            bool IsInputInt2 = int.TryParse(input2, out int number2);

            bool IsInputChar1 = char.TryParse(input1, out char charecter1);
            bool IsInputChar2 = char.TryParse(input2, out char charecter2);

            if (inputType == "int")
            {
                Console.WriteLine(GetIntMax(number1, number2));
            }
            else if (inputType == "char")
            {
                Console.WriteLine(GetCharMax(charecter1, charecter2));
            }
            else if (inputType == "string")
            {
                Console.WriteLine(GetStringMax(input1, input2));
            }

        }
        private static int GetIntMax(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
        private static char GetCharMax(char arg1, char arg2)
        {
            return arg1 > arg2 ? arg1 : arg2;
        }
        private static string GetStringMax(string arg1, string arg2)
        {
            return arg1.CompareTo(arg2) >= 0 ? arg1 : arg2;
        }
    }
}
