namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double priceOfTheHeadset = double.Parse(Console.ReadLine());
            double priceOfTheMouse = double.Parse(Console.ReadLine());
            double priceOfTheKeyboard = double.Parse(Console.ReadLine());
            double priceOfTheDisplay = double.Parse(Console.ReadLine());

            int trashHeadset = 0;
            int trashMouse = 0;
            int trashKeyboard = 0;
            int trashDisplay = 0;

            for (int game = 1; game <= lostGameCount; game++)
            {
                bool headsetBroken = false;
                bool mouseBroken = false;

                if (game % 2 == 0)
                {
                    trashHeadset++;
                    headsetBroken = true;
                }

                if (game % 3 == 0)
                {
                    trashMouse++;
                    mouseBroken = true;
                }

                if (headsetBroken && mouseBroken)
                {
                    trashKeyboard++;

                    if (trashKeyboard % 2 == 0)
                    {
                        trashDisplay++;
                    }
                }
            }

            double totalExpenses =
                trashHeadset * priceOfTheHeadset +
                trashMouse * priceOfTheMouse +
                trashKeyboard * priceOfTheKeyboard +
                trashDisplay * priceOfTheDisplay;

            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");


        }
    }
}
