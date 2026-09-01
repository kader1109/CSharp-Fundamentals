namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();

            bool IsLengthValid = IsPasswordLengthMessage(inputPassword);
            bool IsSymbolCheking = IsPasswordSymbolsCheckingMessage(inputPassword);
            bool IsHasTwoDigits = IsPasswordHasTwoDigits(inputPassword); ;


            if (!IsLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
             if (!IsSymbolCheking)
            {

                Console.WriteLine("Password must consist only of letters and digits");

            }
             if (!IsHasTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(IsLengthValid && IsSymbolCheking && IsHasTwoDigits) 
            {
                Console.WriteLine("Password is valid");
            }

        }


        private static bool IsPasswordLengthMessage(string inputPass)
        {
            return inputPass.Length >= 6 && inputPass.Length <= 10;

        }
        private static bool IsPasswordSymbolsCheckingMessage(string inputPass)
        {

            char[] chars = inputPass.ToCharArray();
            foreach (char c in chars)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;

                }
            }
            return true;
        }
        private static bool IsPasswordHasTwoDigits(string inputPass)
        {            
            int counter = 0;

            char[] chars = inputPass.ToCharArray();

            foreach (char c in chars)
            {

                if (char.IsDigit(c))
                {
                    counter++;
                }
            }
            return counter >= 2;

        }


    }

}

