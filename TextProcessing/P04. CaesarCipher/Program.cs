using System;
using System.Text;

namespace P04._CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            StringBuilder result = new StringBuilder();

            foreach (var item in input)
            {
                var currChar = item + 3;
                var currCharToLetter = (char)(currChar);
                result.Append(currCharToLetter);
            }

            Console.WriteLine(result);
        }
    }
}
