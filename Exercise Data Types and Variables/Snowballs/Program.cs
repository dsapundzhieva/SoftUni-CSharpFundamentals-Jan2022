using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            short numberOfSnowballs = short.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            int snowbalQuality = 0;
            int snowbalTime = 0;
            int snowbalSnow = 0;


            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int currentSnawballSnow = int.Parse(Console.ReadLine());
                int currentsSnawballTime = int.Parse(Console.ReadLine());
                int currentSnawballQuality = int.Parse(Console.ReadLine());
                if (currentsSnawballTime > 0)
                {
                    BigInteger currentsSnowballValue = BigInteger.Pow(currentSnawballSnow / currentsSnawballTime, currentSnawballQuality);

                    if (currentsSnowballValue >= snowballValue)
                    {
                        snowballValue = currentsSnowballValue;
                        snowbalQuality = currentSnawballQuality;
                        snowbalSnow = currentSnawballSnow;
                        snowbalTime = currentsSnawballTime;
                    }
                }

            }
            Console.WriteLine($"{snowbalSnow} : {snowbalTime} = {snowballValue} ({snowbalQuality})");
        }
    }
}
