using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfRealNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < arrayOfRealNumbers.Length; i++)
            {
                var awayFromZero = Math.Round(arrayOfRealNumbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arrayOfRealNumbers[i]} => {awayFromZero}");
            }
        }
    }
}
