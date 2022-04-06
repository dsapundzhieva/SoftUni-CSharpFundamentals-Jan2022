using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
            var topIntegers = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i; k < array.Length - 1; k++)
                {
                    if (array[i] > array[k + 1])
                    {
                        topIntegers[i] = array[i];
                    }
                    else
                    {
                        topIntegers[i] = 0;
                        break;
                    }
                }
                if (array[array.Length - 1] == 0)
                {
                    topIntegers[topIntegers.Length - 1] = int.MinValue;
                }
                else
                {
                    topIntegers[topIntegers.Length - 1] = array[array.Length - 1];
                }

            }
            if (topIntegers[topIntegers.Length - 1] == int.MinValue)
            {
                topIntegers = topIntegers.Where(t => t != 0).ToArray();
                topIntegers[topIntegers.Length - 1] = 0;
            }
            else
            {
                topIntegers = topIntegers.Where(t => t != 0).ToArray();
            }

            Console.Write(string.Join(" ", topIntegers));
        }
    }
}
