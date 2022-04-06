using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
            var count = 0;
            var maxCount = 0;
            var number = 0;
            //2 1 1 2 3 3 2 2 2 1
            for (int i = 0; i < array.Length-1; i++)
            {
                
                if (array[i] == array[i+1])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    number = array[i];
                }
            }

            var newArray = new int[maxCount + 1];
            newArray = newArray.Select(n => n = number).ToArray();
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
