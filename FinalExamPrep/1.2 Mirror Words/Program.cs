using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._2_Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(@|#)(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";

            MatchCollection matchCollection = Regex.Matches(text, pattern);
            List<string> mirrorWords = new List<string>();

            foreach (Match match in matchCollection)
            {
                string word1 = match.Groups["word1"].Value;
                string word2 = match.Groups["word2"].Value;

                var reversed = string.Join("", word2.Reverse());

                if (word1 == reversed)
                {
                    mirrorWords.Add($"{word1} <=> {word2}");
                }
            }

            if (matchCollection.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                if (mirrorWords.Count == 0)
                {
                    Console.WriteLine($"{matchCollection.Count} word pairs found!");
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine($"{matchCollection.Count} word pairs found!");
                    Console.WriteLine($"The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
            }
        }
    }
}
