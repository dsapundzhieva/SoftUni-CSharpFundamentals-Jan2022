using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            int areaOfSquareKm = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {areaOfSquareKm} square km.");
        }
    }
}
