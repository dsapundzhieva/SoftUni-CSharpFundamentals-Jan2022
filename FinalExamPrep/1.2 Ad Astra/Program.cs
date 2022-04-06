using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._2_Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(#|\|)(?<itemName>[A-Za-z\s]+)\1(?<expirationDate>[\d]{2}\/[\d]{2}\/[\d]{2})\1(?<calories>[\d]{1,4}|10000)\1";

            MatchCollection validFoods = Regex.Matches(text, pattern);

            int totalCalories = validFoods
                .Select(x => int.Parse(x.Groups["calories"].Value))
                .Sum();

            Console.WriteLine($"You have food to last you for: {totalCalories/2000} days!");
            foreach (Match match in validFoods)
            {
                string itemName = match.Groups["itemName"].Value;
                string expirationDate = match.Groups["expirationDate"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);

                totalCalories += calories;

                Console.WriteLine($"Item: {itemName}, Best before: {expirationDate}, Nutrition: {calories}");
            }
        }
    }
}
