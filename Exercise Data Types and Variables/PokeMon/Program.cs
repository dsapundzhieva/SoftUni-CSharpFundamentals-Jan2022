using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentPokePower = int.Parse(Console.ReadLine()); //N
            int pokeDistance = int.Parse(Console.ReadLine()); //M
            int exhaustionFactor = int.Parse(Console.ReadLine()); //Y

            int pokecount = 0;
            int pokePower = currentPokePower;


                while (currentPokePower >= pokeDistance)
                {
                    currentPokePower -= pokeDistance;
                    pokecount++;
                    if (currentPokePower == pokePower / 2 && exhaustionFactor != 0)
                    {
                        currentPokePower /= exhaustionFactor;
                    }
                }
            
                Console.WriteLine(currentPokePower);
                Console.WriteLine(pokecount);
        }
    }
}