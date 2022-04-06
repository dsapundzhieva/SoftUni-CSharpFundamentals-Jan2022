using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P05_NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .ToList();

            for (int i = 0; i < names.Count; i++)
            {
                int healthSum = GetHealthPoints(names[i]);
                decimal dmgSum = GetDamagePoints(names[i]);

                Console.WriteLine($"{names[i]} - {healthSum} health, {dmgSum:f2} damage");
            }
        }


        static decimal GetDamagePoints(string demonName)
        {
            string demagePatern = @"(?<price>[\-\+]?\d+(\.\d+)?)";
            string demageSymbols = @"[\*\/*]";

            MatchCollection demageMatches = Regex.Matches(demonName, demagePatern);
            MatchCollection demageSymbolMatches = Regex.Matches(demonName, demageSymbols);

            List<decimal> demageMatchList = new List<decimal>();

            foreach (Match demage in demageMatches)
            {
                demageMatchList.Add(decimal.Parse(demage.Groups["price"].Value));
            }

            decimal dmgSum = demageMatchList.Sum();

            foreach (Match item in demageSymbolMatches)
            {
                if (item.Value == "*")
                {
                    dmgSum *= 2m;
                }
                else
                {
                    dmgSum /= 2m;
                }
            }

            return dmgSum;
        }
        static int GetHealthPoints(string demonName)
        {
            string healthPatern = @"[^0-9\+\-\.\*\/]";
            MatchCollection healthMatches = Regex.Matches(demonName, healthPatern);

            int healthSum = 0;

            foreach (Match health in healthMatches)
            {
                char healthChar = char.Parse(health.Value);

                healthSum += healthChar;
            }

            return healthSum;
        }
    }
}
