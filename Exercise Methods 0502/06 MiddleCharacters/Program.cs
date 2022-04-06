using System;

namespace _06_MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            PrintCharsAtItsMiddle(word);
        }

        static void PrintCharsAtItsMiddle(string word)
        { 
                if (word.Length % 2 != 0)
                {
                    Console.WriteLine(word[word.Length/2]);
                }
                else
                {
                    Console.Write($"{word[word.Length/ 2 -1]}{word[word.Length/2]}");
            }
        }
    }
}
