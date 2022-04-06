using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            var temp = 0;

            for (int i = 0; i < rotations; i++)
            {
                for (int k = 0; k < array.Length-1; k++)
                {
                    temp = array[k];
                    array[k] = array[k + 1];
                    array[k+1] = temp;
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
