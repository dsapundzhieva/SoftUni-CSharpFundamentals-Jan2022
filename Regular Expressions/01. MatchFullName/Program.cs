using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);

            //foreach (Match match in matches)
            //{
            //    Console.Write(match.Value + " ");
            //}

            var linq = matches.Cast<Match>()
                .Select(m => m.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ", linq));
        }
    }
}
