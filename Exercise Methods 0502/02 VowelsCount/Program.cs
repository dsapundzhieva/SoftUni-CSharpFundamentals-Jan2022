using System;
using System.Linq;

namespace _02_VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int vowels = VowelsCount(input);
            Console.WriteLine(vowels);

        }

        static int VowelsCount(string input)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var vowelsCount = 0;

            foreach (char ch in input.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
