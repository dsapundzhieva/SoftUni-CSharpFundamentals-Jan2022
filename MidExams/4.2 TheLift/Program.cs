using System;
using System.Linq;

namespace _4._2_TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            var emptySpots = 0;
            var currentStateOfWagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            for (int i = 0; i < currentStateOfWagons.Length; i++)
            {
                var freeSpots = 4 - currentStateOfWagons[i];
                var spotsToAdd = Math.Min(freeSpots, numberOfPeople);

                currentStateOfWagons[i] += spotsToAdd;
                emptySpots += 4 - currentStateOfWagons[i];
                numberOfPeople -= spotsToAdd;
            }

            if (numberOfPeople == 0 && emptySpots > 0)
            {
                Console.WriteLine($"The lift has empty spots!\n{string.Join(" ", currentStateOfWagons)}");

            }
            else if (numberOfPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {numberOfPeople} people in a queue!\n{string.Join(" ", currentStateOfWagons)}");
            }
            else if (numberOfPeople == 0 && emptySpots == 0)
            {
                Console.WriteLine(string.Join(" ", currentStateOfWagons));
            }
        }
    }
}
