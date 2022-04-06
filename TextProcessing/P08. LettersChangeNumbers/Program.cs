using System;
using System.Linq;


namespace P08._LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0m;

            foreach (var word in input)
            {
                sum += CalculateSingleWordSum(word);
            }

            Console.WriteLine($"{sum:f2}");
        }

        static decimal CalculateSingleWordSum(string word)
        {
            char first = word[0];
            char last = word[word.Length - 1];
            int number = int.Parse(word.Substring(1, word.Length - 2));

            int firstLetterPosition = GetAlphabeticalPositonOfCharacter(first);
            int lastLetterPosition = GetAlphabeticalPositonOfCharacter(last);

            decimal sum = 0m;

            if (firstLetterPosition == -1 || lastLetterPosition == -1)
            {
                return 0m;
            }

            if (char.IsUpper(first))
            {
                sum += (decimal)number / firstLetterPosition;
            }
            else if (char.IsLower(first))
            {
                sum += (decimal)number * firstLetterPosition;
            }

            if (char.IsUpper(last))
            {
                sum -= lastLetterPosition;
            }
            else if (char.IsLower(last))
            {
                sum += lastLetterPosition;
            }

            return sum;
        }

        static int GetAlphabeticalPositonOfCharacter(char ch)
        {
            if (!char.IsLetter(ch))
            {
                return -1;
            }
            else
            {
                ch = char.ToLowerInvariant(ch);

                return (int)ch - 96;
            }
        }
    }
}
