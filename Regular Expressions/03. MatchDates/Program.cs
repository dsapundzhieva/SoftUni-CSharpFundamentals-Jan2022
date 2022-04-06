using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})(?<separator>[-.\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})";

            string date = Console.ReadLine();

            var dates = Regex.Matches(date, regex);

            foreach (Match match in dates)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
            }

        }
    }
}
