
using System;
using System.Linq;

namespace Q01._ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                    

                var name = input.Split('@', StringSplitOptions.RemoveEmptyEntries).Last().Split('|').First();
                var age = input.Split('#', StringSplitOptions.RemoveEmptyEntries).Last().Split('*').First();

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
