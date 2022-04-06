using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._3_Plant_Discovery
{
    class Plant
    {
        public Plant(decimal raiting, int rariry)
        {
            this.Rating = raiting;
            this.Rarity = rariry;
        }
        public decimal Rating { get; set; }
        public int Rarity { get; set; }
        public int Count { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = cmdArgs[0];
                int rarity = int.Parse(cmdArgs[1]);

                Plant plant = new Plant(0m, rarity);

                if (!plants.ContainsKey(plantName))
                {
                    plants.Add(plantName, plant);
                }
                else
                {
                    plants[plantName].Rarity = rarity;
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "Exhibition")
            {
                var cmdArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Split(" - ", StringSplitOptions.RemoveEmptyEntries)).ToList();

                string cmdType = cmdArgs[0][0];

                if (cmdType == "Rate")
                {
                    string plantName = cmdArgs[1][0];
                    decimal raiting = decimal.Parse(cmdArgs[1][1]);

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rating += raiting;
                        plants[plantName].Count++;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdType == "Update")
                {
                    string plantName = cmdArgs[1][0];
                    int newRarity = int.Parse(cmdArgs[1][1]);

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rarity = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdType == "Reset")
                {
                    string plantName = cmdArgs[1][0];

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rating    = 0;
                        plants[plantName].Count = 0;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in plants)
            {
                decimal currRaiting = 0m;
                if (item.Value.Count == 0)
                {
                    currRaiting = 0m;
                }
                else
                {
                    currRaiting = item.Value.Rating / item.Value.Count;
                }
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {currRaiting:f2}");
            }
        }
    }
}
