using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3._2_MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string patern = @"(@|#)(?<word1>[A-Za-z]{3,})(\1)(\1)(?<word2>[A-Za-z]{3,})(\1)";

            MatchCollection matchCollection = Regex.Matches(text, patern);

            if (matchCollection.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matchCollection.Count} word pairs found!");
            }

            //Dictionary<string, string> mirrorWords = new Dictionary<string, string>();

            List<string> mirrorWords = new List<string>(); 

            foreach (Match match in matchCollection)
            {
                string firstWord = match.Groups["word1"].Value;
                string secondWord = match.Groups["word2"].Value;

                string reversedSecondWord = string.Join("", secondWord.Reverse());

                if (firstWord == reversedSecondWord)
                {
                    //mirrorWords.Add(firstWord, secondWord);
                    mirrorWords.Add($"{firstWord} <=> {secondWord}");
                }

            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
                //bool first = true;
                //var myStringBuilder = new StringBuilder();

                //foreach (KeyValuePair<string, string> pair in mirrorWords)
                //{
                //    if (first)
                //    {
                //        first = false;
                //    }
                //    else
                //    {
                //        myStringBuilder.Append(", ");
                //    }

                //    myStringBuilder.AppendFormat("{0} <=> {1}", pair.Key, pair.Value);
                //}

                //var myDesiredOutput = myStringBuilder.ToString();

                //Console.WriteLine(myDesiredOutput);
            }
        }
    }
}
