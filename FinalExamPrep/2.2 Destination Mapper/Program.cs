using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._2_Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string locations = Console.ReadLine();

            string pattern = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";

            MatchCollection validLocations = Regex.Matches(locations, pattern);

            int travelPoints = 0;
            List<string> destinations = new List<string>();
            
            foreach (Match item in validLocations)
            {
                destinations.Add(item.Groups["location"].Value);
                travelPoints += item.Groups["location"].Value.Length;
            }

            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", destinations));
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
