using System;
using System.Collections.Generic;
using System.Linq;

namespace _21_DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> initialQulityDrumSet = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            DecreaseDrumSet(initialQulityDrumSet, savings);
            

        }

        static void DecreaseDrumSet(List<int> drumSet, double money)
        {
            string command;

            List<int> copyDrumSet = new List<int>(drumSet);

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
               
                for (int i = 0; i < copyDrumSet.Count; i++)
                {
                    if (copyDrumSet[i] > hitPower)
                    {
                        copyDrumSet[i] -= hitPower;
                    }
                    else
                    {
                        
                        bool AreMoneyEnough = money >= drumSet[i] * 3;

                        if (AreMoneyEnough)
                        {
                            money -= drumSet[i] * 3;
                            copyDrumSet[i] = drumSet[i];
                        }
                        else
                        {
                            copyDrumSet.RemoveAt(i);
                            drumSet.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", copyDrumSet));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}
