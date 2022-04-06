using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _5._2_EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string emojiPatern = @"(\*\*|\:\:)(?<emoji>[A-Z][a-z]{2,})\1";

            string numPatern = @"\d";

            List<string> emojiList = new List<string>();

            MatchCollection numbMatches = Regex.Matches(text, numPatern);
            MatchCollection emojiMatches = Regex.Matches(text, emojiPatern);

            int coolThresholdSum = 1;

            foreach (Match num in numbMatches)
            {
                coolThresholdSum *= int.Parse(num.Value);
            }

            

            foreach (Match emoji in emojiMatches)
            {
                int emojiSum = 0;

                foreach (var ch in emoji.Groups["emoji"].Value)
                {
                    emojiSum += (int)ch;
                }
                if (emojiSum > coolThresholdSum)
                {
                    emojiList.Add(emoji.Groups[0].Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");

            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");

            foreach (var item in emojiList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
