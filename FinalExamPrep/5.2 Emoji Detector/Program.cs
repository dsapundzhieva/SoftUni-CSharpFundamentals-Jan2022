using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _5._2_Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";

            string digitPattern = @"\d";

            MatchCollection emojiMatches = Regex.Matches(input, pattern);
            MatchCollection digitsMatches = Regex.Matches(input, digitPattern);

            int coolThreshold = 1;
            List<string> emojiList = new List<string>();

            foreach (Match item in digitsMatches)
            {
                int currDigit = int.Parse(item.Value);

                coolThreshold *= currDigit;
            }

            foreach (Match emoji in emojiMatches)
            {
                var currEmoji = emoji.Groups["emoji"].Value;
                int sum= 0;

                foreach (var item in currEmoji)
                {
                    sum += item;
                }
                if (sum >= coolThreshold)
                {
                    emojiList.Add(emoji.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", emojiList));
        }
    }
}
