using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var newArray = new int[array.Length / 2];
       
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length / 4)
                {
                  array[array.Length / 2 - 1 - i] += array[i];
                }
                else if (i >= array.Length / 4 && i < array.Length - array.Length / 4)
                {
                    continue;
                }
                else if (i >= array.Length - array.Length / 4)
                {
                    array[array.Length/2 + array.Length - 1 - i] += array[i];
                }
            }

            Console.Write(string.Join(" ", array.Skip(array.Length/4).Take(array.Length/2)));
        }
    }
}
