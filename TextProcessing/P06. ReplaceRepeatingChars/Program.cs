using System;
using System.Text;

namespace P06._ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length-1; i++)
            {
                char currLetter = input[i];
                char nextLetter = input[i+1];

                if (currLetter != nextLetter)
                {
                    result.Append(currLetter);
                }
                if (input.Length-2 == i)
                {
                    result.Append(input[i+1]);

                }
            }

            Console.WriteLine(result);
        }
    }
}
