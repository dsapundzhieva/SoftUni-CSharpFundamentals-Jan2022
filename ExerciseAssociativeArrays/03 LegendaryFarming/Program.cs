using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string itemObtained = string.Empty;

            Dictionary<string, int> keyMaterialsDic = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 }
            };
            Dictionary<string, int> junkMaterialsDic = new Dictionary<string, int>();
            

            while (string.IsNullOrEmpty(itemObtained))
            {
                var input = Console.ReadLine()
                    .ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                ProcessInputLine(keyMaterialsDic, junkMaterialsDic, input, ref itemObtained);
            }

            PrintOut(keyMaterialsDic, junkMaterialsDic, itemObtained);
        }

        static void PrintOut(Dictionary<string, int> keyMaterialsLeft, Dictionary<string, int> junkMaterialsDic, string itemObtained)
        {
            Console.WriteLine($"{itemObtained} obtained!");

            foreach (var item in keyMaterialsLeft)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkMaterialsDic)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        static void ProcessInputLine(Dictionary<string, int> keyMaterialsDic, Dictionary<string, int> junkMaterialsDic, string[] input, ref string itemObtained)
        {
            const int minCrfatMaterialQty = 250;

            Dictionary<string, string> craftingTable = new Dictionary<string, string>()
            {
                { "shards", "Shadowmourne" },
                { "motes", "Dragonwrath" },
                { "fragments", "Valanyr" }
            };

            for (int i = 0; i < input.Length; i += 2)
            {
                string currMaterial = input[i + 1];
                int currMaterialInt = int.Parse(input[i]);

                if (keyMaterialsDic.ContainsKey(currMaterial))
                {
                    keyMaterialsDic[currMaterial] += currMaterialInt;

                    if (keyMaterialsDic[currMaterial] >= minCrfatMaterialQty)
                    {
                        itemObtained = craftingTable[currMaterial];
                        keyMaterialsDic[currMaterial] -= minCrfatMaterialQty;
                        break;
                    }
                }
                else
                {
                    if (!junkMaterialsDic.ContainsKey(currMaterial))
                    {
                        junkMaterialsDic[currMaterial] = 0;
                    }
                    junkMaterialsDic[currMaterial] += currMaterialInt;
                }
            }
        }
    }
}
