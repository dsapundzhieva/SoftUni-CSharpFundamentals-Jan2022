using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359(\s|-)2\1[0-9]{3}\1[0-9]{4}\b";

            string phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            var matchPhones = phoneMatches
                 .Cast<Match>()
                 .Select(m => m.Value.Trim())
                 .ToArray();

            Console.WriteLine(string.Join(", ", matchPhones));
        }
    }
}
