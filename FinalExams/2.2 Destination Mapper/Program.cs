using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._2_Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> validLocations = new List<string>();
            int travelPoints = 0;

            string text = Console.ReadLine();

            string patern = @"(\=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";

            MatchCollection matchCollection = Regex.Matches(text, patern);
            foreach (Match item in matchCollection)
            {
                validLocations.Add(item.Groups["location"].Value);
                travelPoints += item.Groups["location"].Length;
            }

            Console.Write($"Destinations: ");
            Console.WriteLine(string.Join(", ", validLocations));

            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
