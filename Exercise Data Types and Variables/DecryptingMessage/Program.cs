using System;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            short key = short.Parse(Console.ReadLine());
            short numberOfLines = short.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < numberOfLines; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int sum = character + key;
                char letter = Convert.ToChar(sum);
                result += letter;
            }
            Console.WriteLine(result);
        }
    }
}
