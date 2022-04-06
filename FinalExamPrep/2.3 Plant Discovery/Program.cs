using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._3_Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> plantsRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantsRating = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = cmdArgs[0];
                int rarity = int.Parse(cmdArgs[1]);

                plantsRarity.Add(plant, rarity);
            }

            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                var cmdArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                var cmdArgsSecondSplit = cmdArgs[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Rate")
                {
                    string plantName = cmdArgsSecondSplit[0];
                    int rating = int.Parse(cmdArgsSecondSplit[1]);

                    RatePlant(plantsRating, plantsRarity, plantName, rating);
                }
                else if (cmdType == "Update")
                {
                    string plantName = cmdArgsSecondSplit[0];
                    int newRarity = int.Parse(cmdArgsSecondSplit[1]);

                    UpdateRarity(plantsRarity, plantName, newRarity);
                }
                else if (cmdType == "Reset")
                {
                    string plantName = cmdArgsSecondSplit[0];

                    ResetRating(plantsRating, plantsRarity, plantName);
                }
            }
            PrintOutput(plantsRating, plantsRarity);

        }

        static void PrintOutput(Dictionary<string, List<double>> plantsRating, Dictionary<string, int> plantsRarity)
        {
            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in plantsRarity)
            {
                string plantName = item.Key;
                int rarity = item.Value;
                double avRating = 0;

                if (plantsRating.ContainsKey(plantName) && plantsRating[plantName].Any())
                {
                    avRating = plantsRating[plantName].Average();
                }
                Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {avRating:f2}");
            }
        }
        static void ResetRating(Dictionary<string, List<double>> plantsRating, Dictionary<string, int> plantsRarity, string plantName)
        {
            if (!plantsRarity.ContainsKey(plantName))
            {
                Console.WriteLine("error");
                return;
            }

            if (plantsRating.ContainsKey(plantName))
            {
                plantsRating[plantName].Clear();
            }
        }

        static void UpdateRarity(Dictionary<string, int> plantsRarity, string plantName, int rarity)
        {
            if (!plantsRarity.ContainsKey(plantName))
            {
                Console.WriteLine("error");
            }
            else
            {
                plantsRarity[plantName] = rarity;
            }
        }

        static void RatePlant(Dictionary<string, List<double>> plantsRating, Dictionary<string, int> plantsRarity, string plant, double rating)
        {
            if (!plantsRarity.ContainsKey(plant))
            {
                Console.WriteLine("error");
                return;
            }

            if (!plantsRating.ContainsKey(plant))
            {
                plantsRating[plant] = new List<double>();
            }
            plantsRating[plant].Add(rating);
        }

    }
}
