using System;
using System.Collections.Generic;
using System.Linq;

namespace _33_HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> neighbors = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            int indexToJump = 0;

            while ((command = Console.ReadLine()) != "Love!")
            {
                var cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int jumpLength = int.Parse(cmdArgs[1]);

                indexToJump += jumpLength;

                if (indexToJump > neighbors.Count - 1)
                {
                    indexToJump = 0;

                    if (neighbors[0] > 0)
                    {
                        neighbors[0] -= 2;
                    }
                    else
                    {
                        Console.WriteLine($"Place 0 already had Valentine's day.");
                        continue;
                    }
                }
                else if (indexToJump <= neighbors.Count - 1)
                {
                    if (neighbors[indexToJump] > 0)
                    {
                        neighbors[indexToJump] -= 2;
                    }
                    else
                    {
                        Console.WriteLine($"Place {indexToJump} already had Valentine's day.");
                        continue;
                    }
                }

                if (neighbors[indexToJump] == 0)
                {
                    Console.WriteLine($"Place {indexToJump} has Valentine's day.");
                }

                
            }

            var countPlaces = neighbors.FindAll(x => x > 0).ToArray();

            if (countPlaces.Length == 0)
            {
                Console.WriteLine($"Cupid's last position was {indexToJump}.\nMission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid's last position was {indexToJump}.\nCupid has failed {countPlaces.Length} places.");

            }
        }
    }
}
