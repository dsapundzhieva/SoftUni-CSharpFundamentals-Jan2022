using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace M02._Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            string pattern = @"(?<symbol>[^\d]+)(?<times>[\d]*)";

            MatchCollection matchCollection = Regex.Matches(command, pattern);

            StringBuilder result = new StringBuilder();

            foreach (Match match in matchCollection)
            {
                string symbol = match.Groups["symbol"].Value;
                int times = int.Parse(match.Groups["times"].Value);

                for (int i = 0; i < times; i++)
                {
                    result.Append(symbol.ToUpper());
                }
            }

            List<char> uniqueSymbols = new List<char>();

            foreach (var item in result.ToString())
            {
                if (!uniqueSymbols.Contains(item))
                {
                    uniqueSymbols.Add(item);
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(result.ToString());
        }
    }
}
