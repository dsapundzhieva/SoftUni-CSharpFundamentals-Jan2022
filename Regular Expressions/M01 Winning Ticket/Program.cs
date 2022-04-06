using System;
using System.Text;
using System.Text.RegularExpressions;

namespace M01_Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }


                Match leftSideMatch = Regex.Match(ticket.Substring(0, 10), pattern);
                Match rightSideMatch = Regex.Match(ticket.Substring(10), pattern);

                var matchSymbol = "";

                foreach (var item in leftSideMatch.Value)
                {
                    matchSymbol += item;
                    break;
                }

                var minLengthMatchSymbol = Math.Min(leftSideMatch.Length, rightSideMatch.Length);

                if (!leftSideMatch.Success || !rightSideMatch.Success)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                else
                {
                    if (minLengthMatchSymbol >= 6 && minLengthMatchSymbol < 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {minLengthMatchSymbol}{matchSymbol}");
                        continue;
                    }

                    if (minLengthMatchSymbol == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {minLengthMatchSymbol}{matchSymbol} Jackpot!");
                    }
                }

            }

        }
    }
}
