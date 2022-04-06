using System;
using System.Text.RegularExpressions;

namespace _1._2_Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(#|\|)(?<itemName>[A-Za-z\s]+)\1(?<expirationDate>[\d]{2}\/[\d]{2}\/[\d]{2})\1(?<calories>[0-9][0-9]{0,3}|10000)\1";

            MatchCollection matchCollection = Regex.Matches(text, pattern);

            int numberOfDays = 0;
            foreach (Match match in matchCollection)
            {
                int calories = int.Parse(match.Groups["calories"].Value);
                numberOfDays += calories;
            }

            Console.WriteLine($"You have food to last you for: {numberOfDays / 2000} days!");

            foreach (Match match in matchCollection)
            {
                string itemName = match.Groups["itemName"].Value;
                string expirationDate = match.Groups["expirationDate"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);

                Console.WriteLine($"Item: {itemName}, Best before: {expirationDate}, Nutrition: {calories}");
            }
        }
    }
}
