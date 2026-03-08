namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isBalanced = true;
            bool lastWasOpening = false; // Tracks if the last bracket was '('
            int openCount = 0;           // Tracks number of currently open brackets

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {

                    if (lastWasOpening)
                    {
                        isBalanced = false;
                        break;
                    }
                    lastWasOpening = true;
                    openCount++;
                }
                else if (input == ")")
                {
                    // Cannot close without an open
                    if (openCount == 0)
                    {
                        isBalanced = false;
                        break;
                    }
                    lastWasOpening = false;
                    openCount--;
                }
                // Any other input is ignored (per SoftUni problem statement)
            }

            // After reading all lines, brackets must be fully closed
            if (openCount != 0)
            {
                isBalanced = false;
            }

            Console.WriteLine(isBalanced ? "BALANCED" : "UNBALANCED");
        }
    }
}
