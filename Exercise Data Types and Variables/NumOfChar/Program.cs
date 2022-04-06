using System;

namespace NumOfChar
{
    class Program
    {
        static void Main(string[] args)
        {
            short numberOfNumbers = short.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
