using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            var givenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i; k < array.Length-1; k++)
                {
                    if (array[i] + array[k + 1] == givenNumber)
                    {
                        Console.WriteLine(string.Join(" ", array[i] ,array[k+1]));
                    }
                }
            }

        }
    }
}
