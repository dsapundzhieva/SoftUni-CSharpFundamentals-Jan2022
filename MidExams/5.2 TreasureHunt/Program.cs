using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._2_TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<List<string>, List<int>> sumOfWordsLength = words => words.Aggregate(new List<int>(), (accumulator, currWord) =>
            //{
            //    if (currWord.Length > 5)
            //    {
            //        accumulator.Add(currWord.Length);
            //    }
            //    return accumulator;
            //});

            List<string> initialLoot = Console.ReadLine()
          .Split("|", StringSplitOptions.RemoveEmptyEntries)
          .ToList();

            //var lenghts = sumOfWordsLength(initialLoot);

            string command;

            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                var cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var cmdType = cmdArgs[0];

                if (cmdType == "Loot")
                {
                    string[] items = cmdArgs;

                    initialLoot = Loot(initialLoot, items);
                }
                else if (cmdType == "Drop")
                {
                    int index = int.Parse(cmdArgs[1]);

                    initialLoot = isIndexValid(initialLoot, index) ? initialLoot = Drop(initialLoot, index) : initialLoot;
                }
                else if (cmdType == "Steal")
                {
                    int count = int.Parse(cmdArgs[1]);

                    Steal(initialLoot, count);
                }
            }

            double sum = initialLoot.Select(x => x.Length).ToList().Sum();
            double averageGain = sum / initialLoot.Count;

            if (initialLoot.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }

        static void Steal(List<string> initialLoot, int count)
        {
            
            List<string> stolenItems = new List<string>(initialLoot);

            if (initialLoot.Count >= count)
            {
                initialLoot.RemoveRange(initialLoot.Count - count, count);
                stolenItems.RemoveRange(0, stolenItems.Count - count);
                Console.WriteLine(string.Join(", ", stolenItems));
            }
            else
            {
                initialLoot.RemoveRange(0, initialLoot.Count);
                Console.WriteLine(string.Join(", ", stolenItems));
            }


        }
        static List<string> Drop(List<string> initialLoot, int index)
        {
            string elementTobeDropped = initialLoot.ElementAt(index);

            initialLoot.RemoveAt(index);
            initialLoot.Add(elementTobeDropped);

            return initialLoot;
        }

        static List<string> Loot(List<string> initialLoot, string[] items)
        {

            for (int i = 1; i < items.Length; i++)
            {
                if (!initialLoot.Contains(items[i]))
                {
                    initialLoot.Insert(0, items[i]);
                }
            }
            return initialLoot;
        }

        static bool isIndexValid(List<string> initialList, int index)
        {
            return index >= 0 && index < initialList.Count;
        }
    }
}
