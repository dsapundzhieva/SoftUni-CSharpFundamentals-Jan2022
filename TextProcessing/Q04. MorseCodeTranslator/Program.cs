using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q04._MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> textToMorse = new Dictionary<char, string>()
            {
              {' ', "/"},
              {'A', ".-"},
              {'B', "-..."},
              {'C', "-.-."},
              {'D', "-.."},
              {'E', "."},
              {'F', "..-."},
              {'G', "--."},
              {'H', "...."},
              {'I', ".."},
              {'J', ".---"},
              {'K', "-.-"},
              {'L', ".-.."},
              {'M', "--"},
              {'N', "-."},
              {'O', "---"},
              {'P', ".--."},
              {'Q', "--.-"},
              {'R', ".-."},
              {'S', "..."},
              {'T', "-"},
              {'U', "..-"},
              {'V', "...-"},
              {'W', ".--"},
              {'X', "-..-"},
              {'Y', "-.--"},
              {'Z', "--.."},
            };

            var words = Console.ReadLine()
                .Split('|').Select(s => s.Split(" ", StringSplitOptions.RemoveEmptyEntries))
                .ToList();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Count(); i++)
            {
                string[] word = words[i];
                result.Append(" ");

                for (int k = 0; k < word.Length; k++)
                {
                    string currentLetter = word[k];
                    foreach (var morseLetter in textToMorse)
                    {
                        if (currentLetter.Equals(morseLetter.Value))
                        {
                            result.Append(morseLetter.Key);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }
}
