using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToList();

            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            
            while (command != "end")
            {
                string[] cmdArgs = command.Split();
                var commandToAdd = cmdArgs[0];

                if (commandToAdd == "Add")
                {
                    int passengers = int.Parse(cmdArgs[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengersToAdd = int.Parse(cmdArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengersToAdd <= maxCapacityOfWagon)
                        {
                            wagons[i] += passengersToAdd;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
