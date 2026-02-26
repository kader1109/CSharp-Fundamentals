namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokemonPowerN = int.Parse(Console.ReadLine());
            int distanceBetweenPokemonsM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            int originalPower = pokemonPowerN;
            int countOfTargets = 0;

            while (pokemonPowerN >= distanceBetweenPokemonsM)
            {
                pokemonPowerN -= distanceBetweenPokemonsM;
                countOfTargets++;

                if (pokemonPowerN == originalPower / 2)
                {
                    if (exhaustionFactorY != 0)
                    {
                        pokemonPowerN /= exhaustionFactorY;
                    }
                }
            }

            Console.WriteLine(pokemonPowerN);
            Console.WriteLine(countOfTargets);
        }
    }
}
