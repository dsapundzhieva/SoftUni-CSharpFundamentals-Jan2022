using System;
using System.Collections.Generic;

namespace _03_WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonumDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonumDict.ContainsKey(word))
                {
                    List<string> synonyms = new List<string>();
                    synonyms.Add(synonym);
                    synonumDict.Add(word, synonyms);
                }
                else
                {
                    synonumDict[word].Add(synonym);
                }
            }

            foreach (var item in synonumDict)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
