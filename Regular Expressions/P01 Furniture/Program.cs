using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P01_Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string command;

            string regex = @"^>>([A-Za-z]+)<<(\d+\.?\d+)!(\d+)";

            List<string> furnitures = new List<string>();
            decimal sum = 0m;

            while ((command = Console.ReadLine()) != "Purchase")
            {
                var furnitureMatches = Regex.Match(command, regex);

                if (furnitureMatches.Success)
                {
                    furnitures.Add(furnitureMatches.Groups[1].Value);
                    sum += decimal.Parse(furnitureMatches.Groups[2].Value) * int.Parse(furnitureMatches.Groups[3].Value);
                }
            }

            PrintOutput(furnitures, sum);
        }

        static void PrintOutput(List<string> furnitures, decimal sum)
        {
            Console.WriteLine("Bought furniture:");

            foreach (var item in furnitures)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
