using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            var ZigArray = new int[numbers];
            var ZagArray = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 ==0)
                {
                    ZigArray[i] = input[0];
                    ZagArray[i] = input[1];
                }
                else
                {
                    ZigArray[i] = input[1];
                    ZagArray[i] = input[0];
                }
            }
            Console.Write(string.Join(" ", ZigArray) + "\n");
            Console.Write(string.Join(" ", ZagArray));

        }
    }
}
