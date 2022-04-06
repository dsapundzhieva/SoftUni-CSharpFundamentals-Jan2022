using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var repeatNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatStringByGivenNumber(word, repeatNumber));
        }

        static string RepeatStringByGivenNumber(string inputString, int repatingNumeber) {

            string result = string.Empty;

            for (int i = 0; i < repatingNumeber; i++)
            {
                result += inputString;
            }
            return result;
        }
    }
}
