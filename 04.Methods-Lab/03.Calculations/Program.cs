namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            //string – "add", "multiply", "subtract", "divide".

            switch (command)
            {

                case "add":
                    Console.WriteLine(AddNumbers(num1, num2));
                    break;
                case "multiply":
                    Console.WriteLine(MultiplyNumbers(num1, num2));
                    break;
                case "subtract":
                    Console.WriteLine(SubtractNumbers(num1, num2));
                    break;
                case "divide":
                    Console.WriteLine(DivideNumbers(num1, num2));
                    break;

            }

        }

        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        static int MultiplyNumbers(int num1, int num2)
        {
            return num1 * num2;
        }
        static int SubtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }
        static double DivideNumbers(int num1, int num2)
        {
            return num1 / num2;
        }
    }
    }

