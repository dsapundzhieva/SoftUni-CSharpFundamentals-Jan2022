using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var allWordsAndDefinitions = Console.ReadLine()
                .Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < allWordsAndDefinitions.Length; i++)
            {
                var secondSplit = allWordsAndDefinitions[i].Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string word = secondSplit[0];
                string definition = secondSplit[1];

                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = new List<string>();

                }
                dictionary[word].Add(definition);
                dictionary["new"].Add(definition);
            }

            var teachersWordsCommand = Console.ReadLine()
                .Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            List<string> teachersWords = new List<string>();

            foreach (var item in teachersWordsCommand)
            {
                teachersWords.Add(item);
            }
            
            string finalCommand = Console.ReadLine();

            if (finalCommand == "Test")
            {
                foreach (var word in teachersWords)
                {
                    if (dictionary.ContainsKey(word))
                    {
                        Console.WriteLine($"{word}:");

                        foreach (var definition in dictionary[word])
                        {
                            Console.WriteLine($" -{definition}");
                        }
                    }
                }
            }
            else if (finalCommand == "Hand Over")
            {
                foreach (var word in dictionary)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
