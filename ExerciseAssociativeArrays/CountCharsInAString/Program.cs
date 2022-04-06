using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<char, int> charactersCountDict = new Dictionary<char, int>();

            foreach (var item in input)
            {
                if (!charactersCountDict.ContainsKey(item))
                {
                    charactersCountDict.Add(item, 1);
                }
                else
                {
                    charactersCountDict[item]++;
                }
            }

            charactersCountDict.Remove(' ');

            foreach (var item in charactersCountDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
