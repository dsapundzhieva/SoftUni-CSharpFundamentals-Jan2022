using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace M03._Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            string firstPartPattern = @"([\#\$\%\&])(?<firstPart>[A-Z]+)\1";
            Match firstPartMatch = Regex.Match(input[0], firstPartPattern);

            string secondPartPattern = @"(?<capital>[6][5-9]|[7-8][0-9]|90):(?<lenght>[0-9]{2})";
            MatchCollection secondPartMatch = Regex.Matches(input[1], secondPartPattern);

            string thirdPartPattern = @"[A-Z][^\s]*";
            MatchCollection thirdPartMatch = Regex.Matches(input[2], thirdPartPattern);

            string capitalLettersWord = firstPartMatch.Groups["firstPart"].Value;

            StringBuilder result = new StringBuilder();

            var uniqueMatches = secondPartMatch
                .OfType<Match>()
                .Select(m => m.Value)
                .Distinct().ToList();

            foreach (var firstMatch in capitalLettersWord)
            {
                foreach (var secondMatch in uniqueMatches)
                {
                    string secPattern = @"(?<capital>\d{2}):(?<lenght>\d{2})";

                    Match currMatch = Regex.Match(secondMatch, secPattern);

                    int capitalLetter = int.Parse(currMatch.Groups["capital"].Value);
                    char currCapitalLetter = (char)capitalLetter;

                    if (capitalLetter == firstMatch)
                    {
                        int lenght = int.Parse(currMatch.Groups["lenght"].Value) + 1;

                        foreach (Match thirdMatch in thirdPartMatch)
                        {
                            if (thirdMatch.ToString().StartsWith(currCapitalLetter) && thirdMatch.ToString().Length == lenght)
                            {
                                result.Append(thirdMatch.ToString() + "\n");
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
