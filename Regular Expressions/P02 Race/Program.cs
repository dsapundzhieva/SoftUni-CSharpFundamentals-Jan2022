using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P02_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            Dictionary<string, List<int>> racers = new Dictionary<string, List<int>>();

            while ((command = Console.ReadLine()) != "end of race")
            {
                int sum = 0;
              
                string peternName = @"([A-Za-z])";

                string paternSpeed = @"\d";


                MatchCollection nameMatch = Regex.Matches(command, peternName);

                MatchCollection speedMatch = Regex.Matches(command, paternSpeed);

                StringBuilder name = new StringBuilder();

                foreach (Match matchName in nameMatch)
                {
                    name.Append(matchName.Groups[1].Value);
                }

                foreach (Match match in speedMatch)
                {
                    sum += int.Parse(match.ToString());
                }

                if (names.Contains(name.ToString()))
                {
                    if (!racers.ContainsKey(name.ToString()))
                    {
                        racers.Add(name.ToString(), new List<int> { sum });
                    }
                    else
                    {
                        racers[name.ToString()].Add(sum);
                    }
                }
                else
                {
                    continue;
                }
            }

            int count = 1;

            foreach (var item in racers.OrderByDescending(x => x.Value.Sum()))
            {
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                    count++;
                }
                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                    count++;
                }
                else
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                    break;
                }
            }
        }
    }
}
