using System;
using System.Linq;

namespace ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var arrayUp = new int[number];
            var arrayBottom = new int[number];

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arrayUp[i] = input[0];
                    arrayBottom[i] = input[1];
                }
                else
                {
                    arrayUp[i] = input[1];
                    arrayBottom[i] = input[0];
                }
            }

            Console.WriteLine(string.Join(" ", arrayUp));
            Console.WriteLine(string.Join(" ", arrayBottom));
        }
    }
}
