using System;

namespace _03_CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());
            PrintValuesBetweenTwoChars(firstChar, secondChar);
        }

        static void PrintValuesBetweenTwoChars(char first, char second)
        {
            int firstChar = first;
            int secondChar = second;

            if (firstChar > secondChar)
            {
                var temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }

            for (int i = firstChar + 1; i < secondChar; i++)
            {
                char result = (char)(i);
                Console.Write(string.Join(" ", result + " "));
            }
        }
    }
}
