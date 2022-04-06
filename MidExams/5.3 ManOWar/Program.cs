using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._3_ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
          .Split(">", StringSplitOptions.RemoveEmptyEntries)
          .Select(int.Parse)
          .ToList();

            List<int> warship = Console.ReadLine()
          .Split(">", StringSplitOptions.RemoveEmptyEntries)
          .Select(int.Parse)
          .ToList();

            int maxHealthCapacity = int.Parse(Console.ReadLine());

            string command;

            bool isPrinted = false;

            while ((command = Console.ReadLine()) != "Retire")
            {
                var cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var cmdType = cmdArgs[0];

                if (cmdType == "Fire")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int demage = int.Parse(cmdArgs[2]);

                    if (isIndexValid(warship, index))
                    {
                        warship[index] -= demage;
                        if (warship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            isPrinted = true;
                            return;
                        }
                    }
                }
                else if (cmdType == "Defend")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int demage = int.Parse(cmdArgs[3]);

                    if (isIndexValid(pirateShip, startIndex) && isIndexValid(pirateShip, endIndex))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= demage;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                isPrinted = true;
                                return;
                            }
                        }
                    }
                }
                else if (cmdType == "Repair")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int health = int.Parse(cmdArgs[2]);

                    if (isIndexValid(pirateShip, index))
                    {
                        int availableHealth = maxHealthCapacity - pirateShip[index];

                        if (maxHealthCapacity > pirateShip[index])
                        {
                            pirateShip[index] = availableHealth > health ? pirateShip[index] += health : pirateShip[index] += availableHealth;
                        }
                    }
                }
                else if (cmdType == "Status")
                {
                    Status(pirateShip, maxHealthCapacity);
                }
            }


            if (!isPrinted)
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}\nWarship status: {warship.Sum()}");
            }
        }

        static void Status(List<int> pirateShip, int health)
        {
            var sectionsNeedsRepair = pirateShip
                .ConvertAll(Convert.ToDouble)
                .Select(x => x / health * 100)
                .Where(x => x < 20).ToList();

            Console.WriteLine($"{sectionsNeedsRepair.Count} sections need repair.");
        }


        static bool isIndexValid(List<int> ship, int index)
        {
            return index >= 0 && index < ship.Count;
        }
    }
}
