using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string charCombined = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                char input = char.Parse(Console.ReadLine());
                charCombined += input;
            }
            Console.WriteLine(charCombined);
        }
    }
}
