using System;
using System.Text.RegularExpressions;

namespace _6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"([@|#]+)(?<eggsColor>[a-z]{3,})([@|#]+)([^a-zA-Z0-9]*)(\/+)(?<digits>\d+)(\/+)";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                int amount = int.Parse(match.Groups["digits"].Value);
                string eggsColor = match.Groups["eggsColor"].Value;

                Console.WriteLine($"You found {amount} {eggsColor} eggs!");   
            }
        }
    }
}
