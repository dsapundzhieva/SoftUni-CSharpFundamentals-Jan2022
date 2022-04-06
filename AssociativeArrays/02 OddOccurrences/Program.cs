using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurances = new Dictionary<string, int>();

            foreach (var item in input)
            {
                string toLower = item.ToLower();
                if (occurances.ContainsKey(toLower))
                {
                    occurances[toLower]++;
                }
                else
                {
                    occurances.Add(toLower, 1);
                }
            }

            var oddOccurances = occurances.Where(x => x.Value % 2 != 0).Select(x => x.Key).ToList();

            Console.WriteLine(string.Join(" ", oddOccurances));
        }
    }
}
